using ManagementInternet.Controller;
using ManagementInternet.Models.Entities;
using ManagementInternet.View.Working.Management;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ManagementInternet.View.Working
{
    public partial class CyberManagementFrm : Form
    {
        private AccountController accountController;
        private ComputerController computerController;
        private LoginFrm loginFrm;

        internal AccountController AccountController { get => accountController; set => accountController = value; }
        public LoginFrm LoginFrm { get => loginFrm; set => loginFrm = value; }

        public CyberManagementFrm(LoginFrm loginFrm)
        {
            this.AccountController = new AccountController();
            this.computerController = new ComputerController();
            this.LoginFrm = loginFrm;

            InitializeComponent();
            this.LoginFrm = loginFrm;
        }

        // Bring client data into dgv
        public void getDataIntoDgv()
        {
            this.dgvPlayerManagement.Rows.Clear();

            List<Account> accounts = this.AccountController.getAllUser();

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

            foreach (Computer computer in computers)
            {
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

        private void ToolStripMenuItemService_Click(object sender, EventArgs e)
        {
            Service service = new Service();
            service.Show();
        }

        private void ToolStripMenuItemChangePassword_Click(object sender, EventArgs e)
        {
            ChangePasswordFrm changePasswordFrm = new ChangePasswordFrm(this);  
            changePasswordFrm.ShowDialog();
        }

        private void ToolStripMenuItemRevenue_Click(object sender, EventArgs e)
        {
            RevenueFrm revenueFrm = new RevenueFrm();
            revenueFrm.ShowDialog();
        }
    }
}
