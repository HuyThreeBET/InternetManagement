using ManagementInternet.Controller;
using ManagementInternet.Models.Entities;
using ManagementInternet.View.Working.EmployeeManagement;
using ManagementInternet.View.Working.Management;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ManagementInternet.View.Working
{
    public partial class CyberManagementFrm : Form
    {
        private AccountController accountController;
        private ComputerController computerController;
        private LoginFrm loginFrm;
        //private SocketManagemant socket;
        //private bool got = false;

        internal AccountController AccountController { get => accountController; set => accountController = value; }
        public LoginFrm LoginFrm { get => loginFrm; set => loginFrm = value; }

        private void setManagementPermission()
        {
            byte permission = this.loginFrm.Account.RoleId;

            if (permission == 2)
            {
                this.ToolStripMenuItemStaffManagement.Enabled = false;
                this.ToolStripMenuItemRevenueStatistics.Enabled = false;
                this.ToolStripMenuItemService.Enabled = false;
            }
        }

        public CyberManagementFrm(LoginFrm loginFrm)
        {
            this.AccountController = new AccountController();
            this.computerController = new ComputerController();
            this.LoginFrm = loginFrm;
            //this.socket = new SocketManagemant();

            InitializeComponent();
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
            this.dvgDisplayComputer.Rows.Clear();

            List<Computer> computers = this.computerController.getAll();

            foreach (Computer computer in computers)
            {
                int index = this.dvgDisplayComputer.Rows.Add();

                this.dvgDisplayComputer.Rows[index].Cells[0].Value = "Máy số " + computer.Id.ToString();

                string state = "Không hoạt động";
                if (computer.State == true)
                {
                    this.dvgDisplayComputer.Rows[index].DefaultCellStyle.BackColor = Color.AliceBlue;

                    state = "Đang hoạt động";
                }

                this.dvgDisplayComputer.Rows[index].Cells[1].Value = state;

                if (computer.User != null)
                {
                    this.dvgDisplayComputer.Rows[index].Cells[2].Value = computer.User.Account.AccountName;
                    this.dvgDisplayComputer.Rows[index].Cells[3].Value = computer.StartTime.ToString();
                    this.dvgDisplayComputer.Rows[index].Cells[4].Value = computer.User.Balance.ToString();
                }

                this.dvgDisplayComputer.Rows[index].Cells[5].Value = computer.ComputerType1.Name;
            }
        }

        //private void createServer()
        //{
        //    if (!socket.ConnectServer())
        //    {
        //        socket.CreateServer();

        //        Thread listenThread = new Thread(() =>
        //        {
        //            while (true)
        //            {
        //                try
        //                {
        //                    this.socket.listen();
        //                }
        //                catch
        //                {
        //                }
        //            }
        //        });

        //        listenThread.IsBackground = true;
        //        listenThread.Start();
        //    }
        //    else
        //    {
        //        Thread listenThread = new Thread(() =>
        //        {
        //            this.socket.listen();
        //        });

        //        listenThread.IsBackground = true;
        //        listenThread.Start();
        //    }
        //}

        private void CyberManagementFrm_Load(object sender, EventArgs e)
        {
            //if (!got)
            //{
            //    // Get ip in 2 ways
            //    // Wifi
            //    this.socket.Ip = socket.GetLocalIPv4(NetworkInterfaceType.Wireless80211);

            //    if (string.IsNullOrEmpty(this.socket.Ip))
            //    {
            //        // Ethernet
            //        socket.Ip = socket.GetLocalIPv4(NetworkInterfaceType.Ethernet);
            //    }

            //    got = true;
            //}

            setManagementPermission();
            //createServer();
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

        private void ToolStripMenuItemAddStaff_Click(object sender, EventArgs e)
        {
            AddStaffFrm addStaffFrm = new AddStaffFrm(this);
            addStaffFrm.ShowDialog();
        }

        private void ToolStripMenuItemChangeStaffInfo_Click(object sender, EventArgs e)
        {
            ChangeInfomationFrm changeInfomationStaffFrm = new ChangeInfomationFrm(this);
            changeInfomationStaffFrm.ShowDialog();
        }

        private void toolStripMenuItemRefesh_Click(object sender, EventArgs e)
        {
            CyberManagementFrm_Load(sender, e);
        }

        private void toolStripMenuItemShowStaffStatus_Click(object sender, EventArgs e)
        {
            ShowAllInfoStaffFrm showStaffFrm = new ShowAllInfoStaffFrm();
            showStaffFrm.ShowDialog();
        }

        private void toolStripButtonAddPlayer_Click(object sender, EventArgs e)
        {
            AddPlayerFrm addPlayerFrm = new AddPlayerFrm(this);
            addPlayerFrm.ShowDialog();
        }

        private void toolStripButtonLogout_Click(object sender, EventArgs e)
        {
            this.accountController = null;
            this.computerController = null;
            this.loginFrm = null;
            this.Close();   
        }
    }
}
