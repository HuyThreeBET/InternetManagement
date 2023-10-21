using ManagementInternet.Controller;
using System;
using System.Windows.Forms;

namespace ManagementInternet.View.Client
{
    public partial class ChangingPasswordFrm : Form
    {
        private MainScreenFrm mainScreenFrm;
        private AccountController accountController;

        public ChangingPasswordFrm(MainScreenFrm mainScreenFrm)
        {
            this.mainScreenFrm = mainScreenFrm;
            this.accountController = new AccountController();

            InitializeComponent();
        }

        private void ChangingPasswordFrm_Load(object sender, EventArgs e)
        {
            this.txtAccountName.Text = this.mainScreenFrm.LoginClientFrm.Account.AccountName;
        }

        private bool checkEmptyFields()
        {
            this.error.Clear();

            if (string.IsNullOrEmpty(this.txtAccountName.Text))
            {
                this.error.SetError(this.txtAccountName, "*");
                return false;
            }

            if (string.IsNullOrEmpty(this.txtOldPassword.Text))
            {
                this.error.SetError(this.txtOldPassword, "*");
                return false;
            }

            if (string.IsNullOrEmpty(this.txtNewPassword.Text))
            {
                this.error.SetError(this.txtNewPassword, "*");
                return false;
            }

            if (string.IsNullOrEmpty(this.txtConfirmNewPassword.Text))
            {
                this.error.SetError(this.txtConfirmNewPassword, "*");
                return false;
            }

            return true;
        }

        private void setDefaultFields()
        {
            this.txtOldPassword.Text = string.Empty;
            this.txtNewPassword.Text = string.Empty;
            this.txtConfirmNewPassword.Text = string.Empty;
        }

        private void changePassword()
        {
            string passwordFromDB = this.mainScreenFrm.LoginClientFrm.Account.Passowrd;
            string password = this.mainScreenFrm.LoginClientFrm.Helper.transferPassword(passwordFromDB);

            if (!password.Equals(this.txtOldPassword.Text))
            {
                MessageBox.Show("Sai mật khẩu cũ");
            }
            else
            {
                string newPassword = this.txtNewPassword.Text;
                string confirmNewPassword = this.txtConfirmNewPassword.Text;

                if (!newPassword.Equals(confirmNewPassword))
                {
                    MessageBox.Show("Mật khẩu mới không trùng khớp");
                }
                else
                {
                    this.mainScreenFrm.LoginClientFrm.Account.Passowrd = newPassword;
                    this.accountController.modify(this.mainScreenFrm.LoginClientFrm.Account);

                    setDefaultFields();

                    MessageBox.Show("Thay đổi mật khẩu thành công");
                }
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (!checkEmptyFields())
            {
                return;
            }

            changePassword();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
