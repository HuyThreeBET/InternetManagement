using ManagementInternet.Controller;
using ManagementInternet.Models.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ManagementInternet.View.Working
{
    public partial class CyberManagementFrm : Form
    {
        private AccountController accountController;
        private UserController userController;
        private ComputerController computerController;

        public CyberManagementFrm()
        { 
            this.accountController = new AccountController();
            this.userController = new UserController();
            this.computerController = new ComputerController();

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

        private void getAllComputers()
        {
            List<Computer> computers = this.computerController.getAll();

            foreach (Computer computer in computers) { 
                int index = this.dvgDisplayComputer.Rows.Add();

                this.dvgDisplayComputer.Rows[index].Cells[0].Value = "Máy số " + computer.Id.ToString();

                string state = "Không hoạt động";
                if (computer.State == true)
                {
                    state = "Đang hoạt động";
                }

                this.dvgDisplayComputer.Rows[index].Cells[1].Value = state;
                this.dvgDisplayComputer.Rows[index].Cells[6].Value = computer.ComputerType1.Name;
            }
        }

        private void CyberManagementFrm_Load(object sender, EventArgs e)
        {
            getDataIntoDgv();
            getAllComputers();
        }

        private void toolStripMenuItemAddPlayer_Click(object sender, EventArgs e)
        {
            AddPlayerFrm addPlayerFrm = new AddPlayerFrm(this);
            addPlayerFrm.ShowDialog();
        }
    }
}
