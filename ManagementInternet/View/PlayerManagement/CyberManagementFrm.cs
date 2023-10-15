using ManagementInternet.Controller;
using ManagementInternet.Models.Entities;
using ManagementInternet.View.PlayerManagement;
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

        public void getDataIntoDgv()
        {
            this.dgvPlayerManagement.Rows.Clear();

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

        private void toolStripMenuItemAddPlayer_Click(object sender, EventArgs e)
        {
            AddPlayerFrm addPlayerFrm = new AddPlayerFrm(this);
            addPlayerFrm.ShowDialog();
        }
    }
}
