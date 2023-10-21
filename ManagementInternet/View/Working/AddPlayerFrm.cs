using ManagementInternet.Controller;
using ManagementInternet.Models.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ManagementInternet.View.Working
{
    public partial class AddPlayerFrm : Form
    {
        private CyberManagementFrm cyberManagementFrm;
        private UserController userController;

        public AddPlayerFrm(CyberManagementFrm cyberManagementFrm)
        {
            this.cyberManagementFrm = cyberManagementFrm;
            this.userController = new UserController();

            InitializeComponent();
        }

        private void setDefaultTextAddingPlayerTab()
        {
            this.txtIdCard.Text = string.Empty;
            this.txtAccountName.Text = string.Empty;
            this.rbMale.Checked = true;
            this.txtPassword.Text = string.Empty;
        }
        private void setDefaultTextRechargingTab()
        {
            this.txtSearch.Text = string.Empty; 
            this.txtRAccountName.Text = string.Empty;   
            this.txtAmountOfMoney.Text = string.Empty;
        }

        private bool checkInfo()
        {
            this.error.Clear();

            if (string.IsNullOrEmpty(this.txtIdCard.Text))
            {
                this.error.SetError(this.txtIdCard, "*");
                return false;
            }

            if (this.cyberManagementFrm.AccountController.checkDuplicaton(this.txtIdCard.Text))
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
            user.Id = this.txtIdCard.Text;

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

            this.cyberManagementFrm.AccountController.modify(account);
            this.userController.modify(user);

            MessageBox.Show("Thêm hội viên thành công");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!checkInfo())
            {
                return;
            }

            add();
            setDefaultTextAddingPlayerTab();

            List<Account> accounts = this.cyberManagementFrm.AccountController.getAllUser();
            this.cyberManagementFrm.getDataIntoDgv();
        }

        private void setTrue()
        {
            this.txtRAccountName.Enabled = true;
            this.txtAmountOfMoney.Enabled = true;
            this.btnRecharge.Enabled = true;
        }

        private void setFalse()
        {
            this.txtRAccountName.Enabled = false;
            this.txtAmountOfMoney.Enabled = false;
            this.btnRecharge.Enabled = false;
        }

        private void search(string accountname)
        {
            User user = this.userController.getByAccountname(accountname);

            if (user == null)
            {
                MessageBox.Show("Không tồn tại tài khoản");
                return;
            }
            else
            {
                setTrue();

                this.txtRAccountName.Text = user.Account.AccountName;
            }
        }

        private void recharge(string accountname)
        {
            try
            {
                User user = this.userController.getByAccountname(accountname);

                if (decimal.Parse(this.txtAmountOfMoney.Text) < 0)
                {
                    MessageBox.Show("Số tiền nhập không được là số âm");
                    return;
                }

                decimal balance = user.Balance + decimal.Parse(this.txtAmountOfMoney.Text);

                user.Balance = balance;

                this.userController.modify(user);

                MessageBox.Show("Nạp tiền thành công ");
            }
            catch
            {
                MessageBox.Show("Số tiền nhập không hợp lệ");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            search(this.txtSearch.Text);
        }

        private void btnRecharge_Click(object sender, EventArgs e)
        {
            recharge(this.txtSearch.Text);

            setDefaultTextRechargingTab();
            setFalse();

            this.cyberManagementFrm.getDataIntoDgv();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
