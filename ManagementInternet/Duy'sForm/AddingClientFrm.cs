using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ManagementInternet.Duy_sForm
{
    public partial class AddingClientFrm : Form
    {
        public AddingClientFrm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar == ' ') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || e.KeyChar == (char)8))
                e.Handled = true;
        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))
                e.Handled = true;
        }

        private void txtRecharge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))
                e.Handled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtPhoneNumber.Text) || string.IsNullOrEmpty(txtUser.Text) || string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin");
            }
            else if (!string.IsNullOrEmpty(txtName.Text) || !string.IsNullOrEmpty(txtPassword.Text) || !string.IsNullOrEmpty(txtPhoneNumber.Text) || !string.IsNullOrEmpty(txtUser.Text) || !string.IsNullOrEmpty(txtId.Text) == true)
            {
                MessageBox.Show("Đăng ký thành công!" + "\nThời gian đăng ký: " + dtpInnitiatedDate.Value.ToShortDateString());
            }
            SetDefault();

        }

        private void SetDefault()
        {
            txtId.Text = txtName.Text = txtPassword.Text = txtPhoneNumber.Text = txtRecharge.Text = txtUser.Text = string.Empty;
            dtpDateOfBirth.Value = DateTime.Now;
            rbMale.Checked = true;
        }
    }
}
