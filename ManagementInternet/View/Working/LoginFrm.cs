using ManagementInternet.Controller;
using ManagementInternet.Models.Entities;
using System.Windows.Forms;

namespace ManagementInternet.View.Working
{
    public partial class LoginFrm : Form
    {
        private AccountController accountController;
        private Account account;

        public Account Account { get => account; set => account = value; }

        public LoginFrm()
        {
            this.accountController = new AccountController();   
            this.Account = null;

            InitializeComponent();
        }

        private void loggin()
        {
            this.Account = this.accountController.getByAccountName(this.txtAccountName.Text);

            if (this.Account != null && this.txtPassword.Text.Equals(this.txtPassword.Text) && this.Account.RoleId == 2)
            {
                CyberManagementFrm cyberManagementFrm = new CyberManagementFrm();
                cyberManagementFrm.Show();

                this.Hide();
            }
            else
            {
                this.txtPassword.Text = string.Empty;
            }
        }

        private void btnLogIn_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtAccountName.Text))
            {
                return;
            }

            loggin();   
        }
    }
}

