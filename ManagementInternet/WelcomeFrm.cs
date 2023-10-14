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

        private void btnOpenEmployeeForm_Click(object sender, System.EventArgs e)
        {
            CyberManagementFrm cyberManagementFrm = new CyberManagementFrm();
         
            cyberManagementFrm.Show();

            this.Hide();
        }
    }
}