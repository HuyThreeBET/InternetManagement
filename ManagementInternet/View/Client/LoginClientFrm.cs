﻿using ManagementInternet.Controller;
using ManagementInternet.Models.Entities;
using System;
using System.Windows.Forms;

namespace ManagementInternet.View.Client
{
    public partial class LoginClientFrm : Form
    {
        private AccountController accountController;
        private UserController userControlelr;
        private ComputersFrm computersFrm;
        private Account account;
        private User user;
        private PlayTimeManagement playTimeManagement;

        public Account Account { get => account; set => account = value; }
        public User User { get => user; set => user = value; }
        public ComputersFrm ComputersFrm { get => computersFrm; set => computersFrm = value; }
        public PlayTimeManagement PlayTimeManagement { get => playTimeManagement; set => playTimeManagement = value; }

        public LoginClientFrm(ComputersFrm computersFrm)
        {
            this.accountController = new AccountController();
            this.userControlelr = new UserController(); 
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
            this.Account = this.accountController.getByAccountName(this.txtAccountName.Text);

            if (this.Account != null && this.txtPassword.Text.Equals(this.txtPassword.Text) && this.Account.RoleId == 1)
            {
                this.user = this.userControlelr.getByAccountname(this.txtAccountName.Text); 
               
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
