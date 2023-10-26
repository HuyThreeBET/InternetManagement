using ManagementInternet.Controller;
using ManagementInternet.Function;
using ManagementInternet.Models.Entities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ManagementInternet.View.Client
{
    public partial class LoginClientFrm : Form
    {
        private AccountController accountController;
        private UserController userControlelr;
        private Helper helper;
        private ComputersFrm computersFrm;
        private Account account;
        private User user;
        private PlayTimeManagement playTimeManagement;

        public Account Account { get => account; set => account = value; }
        public User User { get => user; set => user = value; }
        public ComputersFrm ComputersFrm { get => computersFrm; set => computersFrm = value; }
        public PlayTimeManagement PlayTimeManagement { get => playTimeManagement; set => playTimeManagement = value; }
        internal UserController UserControlelr { get => userControlelr; set => userControlelr = value; }
        internal Helper Helper { get => helper; set => helper = value; }

        public LoginClientFrm(ComputersFrm computersFrm)
        {
            this.accountController = new AccountController();
            this.UserControlelr = new UserController();
            this.Helper = new Helper();
            this.ComputersFrm = computersFrm;
            this.Account = null;
            this.user = null;
            this.PlayTimeManagement = null;

            InitializeComponent();
        }

        private void createPlayTimeManagement()
        {
            this.playTimeManagement = new PlayTimeManagement();
            this.playTimeManagement.IdOfUser = this.Account.Id;
            this.playTimeManagement.StartTime = DateTime.Now;
        }

        private void loggin()
        {
            string accountNameTxt = this.txtAccountName.Text;

            this.Account = this.accountController.getByAccountName(accountNameTxt);

            if (this.Account == null)
            {
                MessageBox.Show("Tên tài khoản không tồn tại");

                this.txtPassword.Text = string.Empty;

                return;
            }

            string passwordTxt = this.txtPassword.Text;
            string passwordFromDB = this.Account.Passowrd;
            string password = Helper.transferPassword(passwordFromDB);

            if (password.Equals(passwordTxt) && this.Account.RoleId == 1)
            {
                this.user = this.UserControlelr.getByAccountname(accountNameTxt);

                this.ComputersFrm.Computer.State = true;
                this.ComputersFrm.Computer.IdOfUser = this.account.Id;
                this.ComputersFrm.Computer.StartTime = DateTime.Now.ToString();
                this.ComputersFrm.ComputerController.modify(this.ComputersFrm.Computer);
                this.computersFrm.SelectingComputer.BackColor = Color.AliceBlue;
                this.computersFrm.SelectingComputer.Enabled = false;

                if (this.user.Balance < 1)
                {
                    MessageBox.Show("Tài khoản của bạn không đủ");
                    return;
                }

                /* When logged in successfully, 
                a table will be created to track when the machine is playing 
                and when it is turned off
                It will end up in MainScreenFrm
                */
                createPlayTimeManagement();

                MainScreenFrm mainScreenFrm = new MainScreenFrm(this);
                mainScreenFrm.Show();

                this.Hide();
                this.ComputersFrm.Hide();
            }
            else
            {
                this.txtPassword.Text = string.Empty;
            }
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtAccountName.Text))
            {
                return;
            }

            loggin();
        }
    }
}

