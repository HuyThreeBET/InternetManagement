using ManagementInternet.Controller;
using System;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace ManagementInternet.View.Client
{
    public partial class MainScreenFrm : Form
    {
        private System.Timers.Timer timer;
        private LoginClientFrm loginClientFrm;
        private PlayTimeManagementController playTimeManagementController;
        private int computerId;
        private bool checkingBalance;
        // i means increase
        private int isecond = 0;
        private int iminute = 0;
        private int ihour = 0;
        // d means decrease
        private int dsecond = 0;
        private int dminute = 0;
        private int dhour = 0;
        private int totalAmountService = 0;

        public LoginClientFrm LoginClientFrm { get => loginClientFrm; set => loginClientFrm = value; }
        public int TotalAmountService { get => totalAmountService; set => totalAmountService = value; }

        // The LoginClientFrm parameter is passed to retrieve information from the previous form
        public MainScreenFrm(LoginClientFrm LoginClientFrm)
        {
            this.LoginClientFrm = LoginClientFrm;
            this.playTimeManagementController = new PlayTimeManagementController();
            this.computerId = this.LoginClientFrm.ComputersFrm.ComputerX;
            this.LoginClientFrm.PlayTimeManagement.IdOfComputer = (short)this.LoginClientFrm.ComputersFrm.ComputerX;
            this.checkingBalance = true;

            InitializeComponent();
        }

        // Calculate the total time equal to the client's balance
        // Assign it to txtTotalTime
        private void totalTime(int price)
        {
            // Calculation formula
            double hourDouble = (double)this.LoginClientFrm.User.Balance / (double)price;
            int hour = (int)hourDouble;

            double remainMoney = (double)this.LoginClientFrm.User.Balance - (double)(hour * price);
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

        // TEST: set 10 seconds to test when timeout then logout
        private void totalTimeTEST()
        {
            this.dhour = 0;
            this.dminute = 0;
            this.dsecond = 10;
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
                if (this.dsecond == 0)
                {
                    this.dsecond = 59;
                }

                this.dsecond--;

                if (this.dsecond == 0)
                {
                    if (this.dminute != 0)
                    {
                        this.dsecond = 59;
                        this.dminute--;
                    }
                }

                if (this.dminute == 0)
                {
                    if (this.dhour != 0)
                    {
                        this.dminute = 59;
                        this.dhour--;
                    }
                }

                // To signal when time is up and send notification to the timeOut function
                if (this.dhour == 0 && this.dminute == 0 && this.dsecond == 0)
                {
                    checkingBalance = false;
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

        // Charge based on client's playing time
        private double prepareTheBill(int price)
        {
            double amountPerMinute = (double)price / 60;
            double minute = ((double)this.isecond / 60) * 60;
            double result = amountPerMinute * minute;

            return result;
        }

        private void logout()
        {
            // After logging out, get the current date and time
            this.LoginClientFrm.PlayTimeManagement.EndTime = DateTime.Now;

            // Formula to calculate the player's balance after playing
            double balance = (double)this.LoginClientFrm.User.Balance;
            double amountUsed = prepareTheBill(this.LoginClientFrm.ComputersFrm.Computer.ComputerType1.Price);

            this.LoginClientFrm.User.Balance = (decimal)(balance - amountUsed);
            this.LoginClientFrm.UserControlelr.modify(this.LoginClientFrm.User);
            this.playTimeManagementController.modify(this.LoginClientFrm.PlayTimeManagement);
            this.loginClientFrm.ComputersFrm.Computer.State = false;
            this.loginClientFrm.ComputersFrm.Computer.IdOfUser = null;
            this.loginClientFrm.ComputersFrm.Computer.StartTime = null;
            this.loginClientFrm.ComputersFrm.ComputerController.modify(this.loginClientFrm.ComputersFrm.Computer);

            if (this.checkingBalance)
            {
                MessageBox.Show("Bạn đã sử dụng: " + amountUsed.ToString());
            }
        }

        // This function will run in parallel
        private async Task timeOut()
        {
            Task timeOut = new Task(() =>
            {
                // Runs endlessly until the timer signal is received
                while (true)
                {
                    if (!this.checkingBalance)
                    {
                        this.Hide();

                        logout();

                        MessageBox.Show("Bạn đã hết số dư");

                        break;
                    }
                }
            }
            );

            timeOut.Start();
        }

        private void MainScreenFrm_Load(object sender, EventArgs e)
        {
            this.gBInfo.Text = this.LoginClientFrm.Account.AccountName;

            setTimer();

            Task logoutWhenTimeOut = timeOut();

            this.timer.Start();
            this.txtCostPlayTime.Text = this.LoginClientFrm.ComputersFrm.Computer.ComputerType1.Price.ToString() + ".000";

            totalTime(this.loginClientFrm.ComputersFrm.Computer.ComputerType1.Price);

            // TEST get out of amount function
            // totalTimeTEST();

            Application.DoEvents();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            logout();

            this.loginClientFrm = null;
            this.playTimeManagementController = null;
            this.Close();
        }

        public void setTotalAmountServie()
        {
            this.txtCostService.Text = this.TotalAmountService.ToString() + ".000.VND";
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            ChangePasswordFrm changePasswordFrm = new ChangePasswordFrm(this);
            changePasswordFrm.ShowDialog();
        }

        private void btnService_Click(object sender, EventArgs e)
        {
            OrderServiceFrm orderServiceFrm = new OrderServiceFrm(this);
            orderServiceFrm.ShowDialog();
        }
    }
}
