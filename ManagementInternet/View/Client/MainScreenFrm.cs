using ManagementInternet.Controller;
using ManagementInternet.Models.Entities;
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
        private int computerId;
        private int second = 0;
        private int minute = 0;
        private int hour = 0;

        public MainScreenFrm(LoginClientFrm LoginClientFrm)
        {
            this.loginClientFrm = LoginClientFrm;
            this.computerController = new ComputerController();
            this.computerId = this.loginClientFrm.ComputersFrm.ComputerX;

            InitializeComponent();
        }

        private void showInfo()
        {
            this.gBInfo.Text = this.loginClientFrm.Account.AccountName;
            this.txtTotalTime.Text = this.loginClientFrm.User.Balance.ToString();
        }

        private void MainScreenFrm_Load(object sender, EventArgs e)
        {
            this.timer = new System.Timers.Timer();
            this.timer.Interval = 1000; // 1s
            this.timer.Elapsed += onTimeEvent;
        }

        private void totalTime()
        {
            Computer computer = this.computerController.getById(this.computerId);

            double price = computer.ComputerType1.Price;

            
        }

        private void onTimeEvent(object sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                this.second++;

                if (this.second == 60)
                {
                    this.second = 0;
                    this.minute++;
                }
                if (this.minute == 60)
                {
                    this.minute = 0;
                    this.hour++;
                }

                this.txtUsedTime.Text = string.Format("{0}:{1}:{2}", this.hour.ToString().PadLeft(2, '0'), this.minute.ToString().PadLeft(2, '0'), this.second.ToString().PadLeft(2, '0'));
                totalTime();
            }));
        }

        private void MainScreenFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.timer.Stop();
            Application.DoEvents();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            this.timer.Start();
        }
    }
}
