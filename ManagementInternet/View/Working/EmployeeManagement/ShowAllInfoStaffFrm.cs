using ManagementInternet.Controller;
using ManagementInternet.Models.Entities;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ManagementInternet.View.Working.EmployeeManagement
{
    public partial class ShowAllInfoStaffFrm : Form
    {
        private StaffController staffController;

        public ShowAllInfoStaffFrm()
        {
            this.staffController = new StaffController();

            InitializeComponent();
        }

        private void getStaffsIntoDgv(List<Staff> staffs)
        {
            this.dgvStaffInfo.Rows.Clear();

            foreach (Staff staff in staffs)
            {
                int index = this.dgvStaffInfo.Rows.Add();

                this.dgvStaffInfo.Rows[index].Cells[0].Value = staff.Id;
                this.dgvStaffInfo.Rows[index].Cells[1].Value = staff.FullName;
                this.dgvStaffInfo.Rows[index].Cells[2].Value = staff.DayOfBirth;

                string status = "Còn làm";

                if (!staff.State)
                {
                    this.dgvStaffInfo.Rows[index].DefaultCellStyle.BackColor = Color.DarkRed;

                    status = "Đã nghỉ";
                }

                this.dgvStaffInfo.Rows[index].Cells[3].Value = status;
                this.dgvStaffInfo.Rows[index].Cells[4].Value = staff.DayOfWork.ToString();

                if (staff.State)
                {
                    this.dgvStaffInfo.Rows[index].Cells[5].Value = string.Empty;
                }
                else
                {
                    this.dgvStaffInfo.Rows[index].Cells[5].Value = staff.DayOff.ToString();
                }

            }
        }

        private void getAllInforOfStaffsIntoDgv()
        {
            List<Staff> staffs = this.staffController.getAll();

            getStaffsIntoDgv(staffs);

        }

        private void ShowAllInfoStaffFrm_Load(object sender, System.EventArgs e)
        {
            getAllInforOfStaffsIntoDgv();
        }

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            this.staffController = null;
            this.Close();   
        }
    }
}
