using ManagementInternet.Controller;
using ManagementInternet.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementInternet.View.Working.EmployeeManagement
{
    public partial class AddStaffFrm : Form
    {
        private CyberManagementFrm cyberManagementFrm;
        private StaffController staffController;

        public AddStaffFrm(CyberManagementFrm cyberManagementFrm)
        {
            this.cyberManagementFrm = cyberManagementFrm;
            this.staffController = new StaffController();

            InitializeComponent();
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

        private void setDefaultTextAddingPlayerTab()
        {
            throw new NotImplementedException();
        }

        private void add()
        {
            throw new NotImplementedException();
        }

        private bool checkInfo()
        {
            throw new NotImplementedException();
        }
    }
}
