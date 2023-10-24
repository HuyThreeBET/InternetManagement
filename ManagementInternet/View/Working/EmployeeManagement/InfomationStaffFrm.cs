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
    public partial class InfomationStaffFrm : Form
    {
        public InfomationStaffFrm()
        {
            InitializeComponent();
        }
                        
        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            InternetManagementContextDB context = new InternetManagementContextDB();
            string cccD = txtSearchID.Text.Trim();

            if (cccD.Length != 12)
            {
                MessageBox.Show("Vui long nhap cccd co 12 chu so");
                return;
            }
            if (!cccD.All(char.IsDigit))
            {
                MessageBox.Show("CCCD chi chua ky su so");
                return;
            }
            var stafF = context.Staffs.FirstOrDefault(st => st.Id == cccD);
            var acc = context.Accounts.FirstOrDefault(ac => ac.Id == cccD);
            if (stafF == null)
            {
                MessageBox.Show("Khong tim thay nhan vien");
            }
            else
            {
                grbInfoStaff.Enabled = true;
                txtName.Text = stafF.FullName;
                dtpDateOfBirth.Text = stafF.DayOfBirth.ToString();
                string Sex = "Nam";
                if (!acc.Sex)
                {
                    Sex = "Nu";

                }
                txtSex.Text = Sex;
                grbAcc.Enabled = true;
                txtUser.Text = acc.AccountName;
                txtPassword.Text = acc.Passowrd;
                if (acc.RoleId == 1)
                {
                    rbSetStaff.Checked = true;
                }
                else
                {
                    rbSetManager.Checked = true;
                }
            }
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            InternetManagementContextDB context = new InternetManagementContextDB();
            string cccD = txtSearchID.Text.Trim();
            var stafF = context.Staffs.FirstOrDefault(st => st.Id == cccD);
            var acc = context.Accounts.FirstOrDefault(ac => ac.Id == cccD);
            stafF.FullName = txtName.Text;
            stafF.DayOfBirth = dtpDateOfBirth.Value.Date;
            acc.AccountName = txtUser.Text;
            acc.Passowrd = txtPassword.Text;
            if (rbSetManager.Checked == true)
            {
                acc.RoleId = 2;
            }
            else
            {
                acc.RoleId = 1;
            }

            context.SaveChanges();
            MessageBox.Show("Cap nhat thanh cong");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
