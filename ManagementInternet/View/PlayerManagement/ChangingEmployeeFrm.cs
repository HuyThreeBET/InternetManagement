using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementInternet.Duy_sForm
{
    public partial class ChangingEmployeeFrm : Form
    {
        public ChangingEmployeeFrm()
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
