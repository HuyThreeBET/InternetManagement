using ManagementInternet;
using System.Windows.Forms;

namespace InternetShop
{
    public partial class WelcomeFrm : Form
    {
        public WelcomeFrm()
        {
            InitializeComponent();
        }

        private void btnOpenStaffForm_Click(object sender, System.EventArgs e)
        {
            Staff staff = new Staff();
            staff.ShowDialog();
        }
    }
}