using ManagementInternet.Function;
using ManagementInternet.Models.Entities;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ManagementInternet.View.Working.Management
{
    public partial class ChangePasswordFrm : Form
    {
        private CyberManagementFrm cyberManagementFrm;
        private Helper helper;

        public ChangePasswordFrm(CyberManagementFrm cyberManagementFrm)
        {
            this.cyberManagementFrm = cyberManagementFrm;
            this.helper = new Helper();

            InitializeComponent();
        }

        private void ChangePasswordFrm_Load(object sender, EventArgs e)
        {
            this.txtAccountName.Text = this.cyberManagementFrm.LoginFrm.Account.AccountName;
        }

        private void setDefaultFields()
        {
            this.txtCurrentPassword.Text = string.Empty;
            this.txtNewPassword.Text = string.Empty;
            this.txtConfirmNewPassword.Text = string.Empty;
        }

        private bool checkEmptyFields()
        {
            this.err.Clear();

            if (string.IsNullOrEmpty(this.txtCurrentPassword.Text))
            {
                this.err.SetError(this.txtCurrentPassword, "*");
                return false;
            }

            if (string.IsNullOrEmpty(this.txtNewPassword.Text))
            {
                this.err.SetError(this.txtNewPassword, "*");
                return false;
            }

            if (string.IsNullOrEmpty(this.txtConfirmNewPassword.Text))
            {
                this.err.SetError(this.txtConfirmNewPassword, "*");
                return false;
            }

            return true;
        }

        private void changePassowrd()
        {
            string currentPassword = this.txtCurrentPassword.Text;
            string passwordFromDB = this.cyberManagementFrm.LoginFrm.Account.Passowrd;
            string password = helper.transferPassword(passwordFromDB);

            if (password.Equals(currentPassword))
            {
                string newPassword = this.txtNewPassword.Text;
                string confirmNewPassword = this.txtConfirmNewPassword.Text;

                if (!newPassword.Equals(confirmNewPassword))
                {
                    MessageBox.Show("Mật khẩu không trùng khớp");
                }
                else
                {
                    this.cyberManagementFrm.LoginFrm.Account.Passowrd = newPassword;

                    Account account = this.cyberManagementFrm.LoginFrm.Account;

                    this.cyberManagementFrm.AccountController.modify(account);

                    setDefaultFields();

                    MessageBox.Show("Đối mật khẩu thành công");
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu hiện tại không đúng");
            }
        }

        private void btnConfirmChangePassword_Click(object sender, EventArgs e)
        {
            if (!checkEmptyFields())
            {
                return;
            }

            changePassowrd();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
