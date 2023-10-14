using ManagementInternet.Models.Entities;
using System;
using System.Windows.Forms;

namespace ManagementInternet
{
    public partial class StaffInformation : Form
    {
        InternetManagementContextDB context = new InternetManagementContextDB();
        private int index = -1;
        public StaffInformation()
        {
            InitializeComponent();
        }
        public void LoadStaffInformation()
        {
            dgvStaffInformation.DataSource = null;
           
           
        }
        private void StaffInformation_Load(object sender, EventArgs e)
        {
            LoadStaffInformation();
        }
        private bool CheckFullName(string txtName)
        {
            if (txtName.Length < 3 || txtName.Length > 100)
                return true;
            else
                return false;
        }
        private bool CheckState(string txtState)
        {
            if (txtState.Length < 3 || txtState.Length > 100)
                return true;
            else
                return false;
        }
        private bool CheckInput()
        {
            errError.Clear();
            if (CheckFullName(txtName.Text))
            {
                MessageBox.Show("Lỗi: Dữ liệu không hợp lệ. Vui lòng kiểm tra lại các trường dữ liệu.", "Lỗi",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(txtName.Text))
            {
                errError.SetError(txtName, "*");
                return false;
            }
            if (CheckState(txtState.Text))
            {
                MessageBox.Show("Lỗi: Dữ liệu không hợp lệ. Vui lòng kiểm tra lại các trường dữ liệu.", "Lỗi",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(txtState.Text))
            {
                errError.SetError(txtState, "*");
                return false;
            }
            return true;
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtState_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnAddUpdate_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                Staff staff = new Staff();
                staff.FullName = txtName.Text.ToString();
                context.SaveChanges();
                LoadStaffInformation();
            }
        }

        private void dgvStaffInformation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                index = e.RowIndex;
                txtID.Text = dgvStaffInformation.Rows[index].Cells[0].Value.ToString();
                txtName.Text = dgvStaffInformation.Rows[index].Cells[1].Value.ToString();
                txtState.Text = dgvStaffInformation.Rows[index].Cells[2].Value.ToString();
            }
        }
    }
}
