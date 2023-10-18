using ManagementInternet.View.Client;
using ManagementInternet.View.Working;
using System.Windows.Forms;

namespace ManagementInternet.View
{
    public partial class WelcomeFrm : Form
    {
        public WelcomeFrm()
        {
            InitializeComponent();
        }

        private void btnOpenEmployeeForm_Click(object sender, System.EventArgs e)
        {
            LoginFrm loginFrm = new LoginFrm();
            loginFrm.Show();

            this.Hide();
        }

        private void btnOpenClientForm_Click(object sender, System.EventArgs e)
        {
            ComputersFrm computerFrm = new ComputersFrm();
            computerFrm.Show();

            this.Hide();
        }
    }
}