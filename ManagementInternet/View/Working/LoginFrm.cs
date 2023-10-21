using ManagementInternet.Controller;
using ManagementInternet.Function;
using ManagementInternet.Models.Entities;
using System.Windows.Forms;

namespace ManagementInternet.View.Working
{
    public partial class LoginFrm : Form
    {
        private AccountController accountController;
        private Account account;
        private Helper helper;

        public Account Account { get => account; set => account = value; }
        internal Helper Helper { get => helper; set => helper = value; }

        public LoginFrm()
        {
            this.accountController = new AccountController();   
            this.Account = null;
            this.Helper = new Helper(); 

            InitializeComponent();
        }

        private void loggin()
        {
            this.Account = this.accountController.getByAccountName(this.txtAccountName.Text);

            string passwordFromDB = this.Account.Passowrd;
            string passowrdTxt = this.txtPassword.Text;
            string passowrd = Helper.transferPassword(passwordFromDB);

            if (this.Account == null)
            {
                this.txtPassword.Text = string.Empty;
                return;
            }

            if (passowrd.Equals(passowrdTxt) && this.Account.RoleId == 2)
            {
                CyberManagementFrm cyberManagementFrm = new CyberManagementFrm(this);
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

