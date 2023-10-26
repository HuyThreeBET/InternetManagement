using ManagementInternet.Controller;
using ManagementInternet.Models.Entities;
using System;
using System.Windows.Forms;

namespace ManagementInternet.View.Working.Management
{
    public partial class ChangeInfomationFrm : Form
    {
        private CyberManagementFrm cyberManagementFrm;
        private StaffController staffController;
        private Account account;
        private Staff staff;
        private int check = -1;

        public ChangeInfomationFrm(CyberManagementFrm cyberManagementFrm)
        {
            this.cyberManagementFrm = cyberManagementFrm;
            this.staffController = new StaffController();
            this.account = null;
            this.staff = null;

            InitializeComponent();
        }

        private bool checkEmptyFields()
        {
            this.error.Clear();

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

            return true;
        }

        private void setDefaultFields()
        {
            this.txtFullName.Text = string.Empty;

            DateTime defaultDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);

            this.dtpDOB.Value = defaultDate;
            this.rbMale.Checked = true;
            this.rbStaff.Checked = true;
        }

        private void setEnabledTrue()
        {
            this.txtFullName.Enabled = true;
            this.dtpDOB.Enabled = true;
            this.rbFemale.Enabled = true;
            this.rbMale.Enabled = true;
            this.rbStaff.Enabled = true;
            this.rbManager.Enabled = true;
            this.btnModify.Enabled = true;
            this.btnCancel.Enabled = true;
            this.rdBYes.Enabled = true;
            this.rdBNo.Enabled = true;
        }

        private void setEnabledFalse()
        {
            this.txtFullName.Enabled = false;
            this.dtpDOB.Enabled = false;
            this.rbFemale.Enabled = false;
            this.rbMale.Enabled = false;
            this.rbStaff.Enabled = false;
            this.rbManager.Enabled = false;
            this.btnModify.Enabled = false;
            this.btnCancel.Enabled = false;
            this.rdBYes.Enabled = false;
            this.rdBNo.Enabled = false;
        }

        private void fillInfo(Account account)
        {
            setEnabledTrue();

            string id = account.Id;

            this.staff = this.staffController.getById(id);
            this.txtFullName.Text = this.staff.FullName;

            if (account.Sex)
            {
                this.rbMale.Checked = true;
            }
            else
            {
                this.rbFemale.Checked = true;
            }

            if (account.RoleId == 2)
            {
                this.rbStaff.Checked = true;
            }
            else
            {
                this.rbManager.Checked = true;
            }
        }

        private void search()
        {
            string info = this.txtInfo.Text;

            this.account = this.cyberManagementFrm.AccountController.getByAccountName(info);

            if (account == null)
            {
                account = this.cyberManagementFrm.AccountController.getById(info);
            }
            else
            {
                this.txtInfo.Text = string.Empty;

                fillInfo(account);
            }

            if (account == null)
            {
                MessageBox.Show("Thông tin tìm kiếm bị sai");
            }
            else
            {
                this.txtInfo.Text = string.Empty;

                fillInfo(account);
            }

            if (this.staff.State)
            {
                this.check = 1;
                this.rdBNo.Checked = true;
            }
            else
            {
                this.check = 0;
                this.rdBYes.Checked = true;
            }
        }

        private void modify()
        {
            string fullName = this.txtFullName.Text.ToLower();
            string dayOfBirthString = this.dtpDOB.Value.ToString("yyyy-MM-dd");
            bool sex = true;

            if (this.rbFemale.Checked)
            {
                sex = false;
            }

            byte role = 2;

            if (this.rbManager.Checked)
            {
                role = 3;
            }

            bool status = true;

            if (this.rdBYes.Checked)
            {
                status = false;
            }

            this.account.Sex = sex;
            this.account.RoleId = role;
            this.staff.Id = this.account.Id;
            this.staff.FullName = fullName.ToLower();
            this.staff.DayOfBirth = dayOfBirthString;
            this.staff.State = status;
            this.staff.DayOff = DateTime.Now;
            this.cyberManagementFrm.AccountController.modify(this.account);
            this.staffController.modify(staff);
            this.account = null;

            if (this.rdBNo.Checked)
            {
                this.rdBNo.Checked = false;
            }

            if (this.rdBYes.Checked)
            {
                this.rdBYes.Checked = false;
            }

            MessageBox.Show("Sửa thành công");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtInfo.Text))
            {
                return;
            }

            search();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.rdBNo.Checked && this.check != 1)
            {
                modify();
                setDefaultFields();
                setEnabledFalse();
            }
            else if (this.rdBYes.Checked && this.check != 0)
            {
                modify();
                setDefaultFields();
                setEnabledFalse();
            }
            else if (!checkEmptyFields())
            {
                return;
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            setDefaultFields();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.cyberManagementFrm = null;
            this.staffController = null;
            this.account = null;
            this.staff = null;
            this.Hide();
        }
    }
}
