using ManagementInternet.Controller;
using ManagementInternet.Models.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ManagementInternet
{
    public partial class CyberManagementFrm : Form
    {
        private AccountController accountController;
        private UserController userController;

        public CyberManagementFrm()
        {
            this.userController = new UserController();
            this.accountController = new AccountController();

            InitializeComponent();
        }

        private void getDataIntoDgv()
        {
            List<Account> accounts = this.accountController.getAllUser();

            foreach (Account account in accounts)
            {
                int index = this.dgvPlayerManagement.Rows.Add();

                this.dgvPlayerManagement.Rows[index].Cells[0].Value = account.Id;
                this.dgvPlayerManagement.Rows[index].Cells[1].Value = account.AccountName;

                string sex = "Nam";

                if (!account.Sex)
                {
                    sex = "Nữ";
                }

                this.dgvPlayerManagement.Rows[index].Cells[2].Value = sex;
                this.dgvPlayerManagement.Rows[index].Cells[3].Value = account.User.Balance.ToString();
                this.dgvPlayerManagement.Rows[index].Cells[4].Value = account.CreateAt.ToString();
            }
        }

        private void CyberManagementFrm_Load(object sender, EventArgs e)
        {
            getDataIntoDgv();
        }

        private void setDefaultText()
        {
            this.txtIdCard.Text = string.Empty;
            this.txtAccountName.Text = string.Empty;
            this.rbMale.Checked = true;
            this.txtPassword.Text = string.Empty;
        }

        private bool checkInfo()
        {
            this.error.Clear();

            if (string.IsNullOrEmpty(this.txtIdCard.Text))
            {
                this.error.SetError(this.txtIdCard, "*");
                return false;
            }

            if (this.accountController.getById(this.txtIdCard.Text))
            {
                this.error.SetError(this.txtIdCard, "*");
                MessageBox.Show("Trùng căn cước công dân");
                return false;
            }

            if (string.IsNullOrEmpty(this.txtAccountName.Text))
            {
                this.error.SetError(this.txtAccountName, "*");
                return false;
            }

            if (string.IsNullOrEmpty(this.txtPassword.Text))
            {
                this.error.SetError(this.txtPassword, "*");
                return false;
            }

            return true;
        }

        private void add()
        {
            Account account = new Account();
            User user = new User();

            user.Id = account.Id;

            account.Id = this.txtIdCard.Text;
            account.AccountName = this.txtAccountName.Text;
            account.Passowrd = this.txtPassword.Text;

            if (this.rbMale.Checked)
            {
                account.Sex = true;
            }
            else
            {
                account.Sex = false;
            }

            account.CreateAt = DateTime.Now;
            account.RoleId = 1;

            user.Id = account.Id;

            this.accountController.modify(account);
            this.userController.modify(user);

            MessageBox.Show("Thêm hội viên thành công");

            CyberManagementFrm_Load(null, null);
            setDefaultText();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (checkInfo())
            {
                return;
            }

            add();
        }
    }
}
