using System;
using System.Windows.Forms;

namespace ManagementInternet.PlayerManagement
{
    public partial class LoginEmployeeFrm : Form
    {
        public LoginEmployeeFrm()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUser.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin");
            }
            else if (!string.IsNullOrEmpty(txtUser.Text) || !string.IsNullOrEmpty(txtPassword.Text) == true)
            {
                MessageBox.Show("Đăng nhập thành công!");
            }
        }
    }
}
