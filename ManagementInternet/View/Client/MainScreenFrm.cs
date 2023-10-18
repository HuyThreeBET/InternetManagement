using ManagementInternet.Controller;
using System;
using System.Timers;
using System.Windows.Forms;

namespace ManagementInternet.View.Client
{
    public partial class MainScreenFrm : Form
    {
        private LoginClientFrm loginClientFrm;
        private System.Timers.Timer timer;
        private ComputerController computerController;
        private PlayTimeManagementController playTimeManagementController;
        private UserController userController;
        private int computerId;
        private int isecond = 0;
        private int iminute = 0;
        private int ihour = 0;
        private int dsecond = 0;
        private int dminute = 0;
        private int dhour = 0;

        public MainScreenFrm(LoginClientFrm LoginClientFrm)
        {
            this.loginClientFrm = LoginClientFrm;
            this.computerController = new ComputerController();
            this.playTimeManagementController = new PlayTimeManagementController(); 
            this.userController = new UserController();
            this.computerId = this.loginClientFrm.ComputersFrm.ComputerX;
            this.loginClientFrm.PlayTimeManagement.IdOfComputer = (short)this.loginClientFrm.ComputersFrm.ComputerX;

            InitializeComponent();
        }

        private void totalTime(int price)
        {
            double hourDouble = (double)this.loginClientFrm.User.Balance / (double)price;
            int hour = (int)hourDouble;

            double remainMoney = (double)this.loginClientFrm.User.Balance - (double)(hour * price);
            double moneyIntoMinute = remainMoney / (double)price;
            double minuteDouble = moneyIntoMinute * 60;
            int minute = (int)minuteDouble;

            double residualMinute = minuteDouble - (double)minute;
            double secondDouble = residualMinute * 60;
            int second = (int)secondDouble;

            this.dhour = hour;
            this.dminute = minute;
            this.dsecond = second;

            this.txtTotalTime.Text = this.dhour.ToString().PadLeft(2, '0') + ":" + this.dminute.ToString().PadLeft(2, '0') + ":" + this.dsecond.ToString().PadLeft(2, '0');
        }

        private void setTimer()
        {
            this.timer = new System.Timers.Timer();
            this.timer.Interval = 1000; // 1s
            this.timer.Elapsed += increaseTime;
            this.timer.Elapsed += decreaseTime;
        }

        private void decreaseTime(object sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                this.dsecond--;

                if (this.dsecond == 0)
                {
                    this.dsecond = 59;
                    this.dminute--;
                }
                if (this.dminute == 0)
                {
                    this.dminute = 59;
                    this.dhour--;
                }

                this.txtRemainTime.Text = string.Format("{0}:{1}:{2}", this.dhour.ToString().PadLeft(2, '0'), this.dminute.ToString().PadLeft(2, '0'), this.dsecond.ToString().PadLeft(2, '0'));
            }));
        }

        private void increaseTime(object sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                this.isecond++;

                if (this.isecond == 60)
                {
                    this.isecond = 0;
                    this.iminute++;
                }
                if (this.iminute == 60)
                {
                    this.iminute = 0;
                    this.ihour++;
                }

                this.txtUsedTime.Text = string.Format("{0}:{1}:{2}", this.ihour.ToString().PadLeft(2, '0'), this.iminute.ToString().PadLeft(2, '0'), this.isecond.ToString().PadLeft(2, '0'));
            }));
        }

        private void MainScreenFrm_Load(object sender, EventArgs e)
        {
            setTimer();

            this.timer.Start();
            this.txtCostPlayTime.Text = this.loginClientFrm.ComputersFrm.Computer.ComputerType1.Price.ToString();

            Application.DoEvents();

            totalTime(this.loginClientFrm.ComputersFrm.Computer.ComputerType1.Price);
        }

        private double prepareTheBill(int price)
        {
            double amountPerMinute = (double)price / 60;

            double minute = ((double)this.dsecond / 60) * 600;

            double result = amountPerMinute * minute;

            return result;
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
           
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.loginClientFrm.PlayTimeManagement.EndTime = DateTime.Now;

            double balance = (double)this.loginClientFrm.User.Balance;
            double amountUsed = prepareTheBill(this.loginClientFrm.ComputersFrm.Computer.ComputerType1.Price);

            this.loginClientFrm.User.Balance = (decimal)(balance - amountUsed);
            this.userController.modify(this.loginClientFrm.User);
            this.playTimeManagementController.modify(this.loginClientFrm.PlayTimeManagement);
        
            Application.Exit();
        }
    }
}
