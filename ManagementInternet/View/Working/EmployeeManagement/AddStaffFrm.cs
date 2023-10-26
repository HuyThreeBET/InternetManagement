using ManagementInternet.Controller;
using ManagementInternet.Models.Entities;
using System;
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
        private void AddStaffFrm_Load(object sender, EventArgs e)
        {
            this.gBAddStaff.Text = this.cyberManagementFrm.LoginFrm.Account.AccountName;
        }

        private bool checkEmptyFields()
        {
            this.error.Clear();

            if (string.IsNullOrEmpty(this.txtId.Text))
            {
                this.error.SetError(this.txtId, "*");

                return false;
            }

            if (string.IsNullOrEmpty(this.txtFullName.Text))
            {
                this.error.SetError(this.txtFullName, "*");

                return false;
            }

            string yearInDtpString = this.dtpDOB.Value.Year.ToString();
            string currentYearString = DateTime.Now.Year.ToString();

            int yearInDtp = Int32.Parse(yearInDtpString);
            int currentYear = int.Parse(currentYearString);

            if (currentYear - yearInDtp < 18)
            {
                MessageBox.Show("Không đủ 18 tuổi");

                return false;
            }

            if (string.IsNullOrEmpty(this.txtAccountName.Text))
            {
                this.error.SetError(this.txtAccountName, "*");

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
            try
            {
                Account account = new Account();
                Staff staff = new Staff();

                string id = this.txtId.Text;
                string fullName = this.txtFullName.Text;
                string dayOfBirthString = this.dtpDOB.Value.ToString("yyyy-MM-dd");
                string accountName = this.txtAccountName.Text;
                string passowrd = this.txtPassword.Text;

                account.Id = id;
                account.AccountName = accountName;
                account.Passowrd = passowrd;

                if (this.rbMale.Checked)
                {
                    account.Sex = true;
                }
                else
                {
                    account.Sex = false;
                }

                if (this.rbStaff.Checked)
                {
                    account.RoleId = 2;
                }
                else
                {
                    account.RoleId = 3;
                }

                account.CreateAt = DateTime.Now;

                staff.Id = id;
                staff.FullName = fullName.ToLower();
                staff.DayOfBirth = dayOfBirthString;
                staff.State = true;
                staff.DayOfWork = DateTime.Now;
                staff.DayOff = DateTime.Now;

                this.cyberManagementFrm.AccountController.modify(account);
                this.staffController.modify(staff);

                MessageBox.Show("Thêm thành công");
            }
            catch
            {
                MessageBox.Show("Trùng căn cước công dân");
            }
        }

        private void setDefaultFields()
        {
            this.txtId.Text = string.Empty;
            this.txtFullName.Text = string.Empty;

            DateTime defaultDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            this.dtpDOB.Value = defaultDate;
            this.rbMale.Checked = true;
            this.txtAccountName.Text = string.Empty;
            this.txtPassword.Text = string.Empty;
            this.rbStaff.Checked = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!checkEmptyFields())
            {
                return;
            }

            add();
            setDefaultFields();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            setDefaultFields();
        }

        void setNull()
        {
            this.cyberManagementFrm = null;
            this.staffController = null;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            setNull();
            this.Hide();
        }

    }
}
