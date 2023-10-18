using ManagementInternet.Controller;
using ManagementInternet.Models.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ManagementInternet.View.Client
{
    public partial class ComputersFrm : Form
    {
        private ComputerController computerController;
        private List<Computer> computers;
        private Computer computer;
        private int computerX;

        public int ComputerX { get => computerX; set => computerX = value; }
        public Computer Computer { get => computer; set => computer = value; }

        public ComputersFrm()
        {
            this.computerController = new ComputerController();
            this.computers = null;
            this.Computer = null;

            InitializeComponent();
        }

        private void createComputers()
        {
            this.computers = this.computerController.getAll();

            foreach (Computer computer in computers)
            {
                Button button = new Button()
                {
                    Width = 230,
                    Height = 57
                };

                string computerName = "Máy số " + computer.Id.ToString();

                button.Text = computerName;
                button.Click += btn_Click;

                this.tableLayoutPanelComputer.Controls.Add(button);
            }
        }

        private void Computers_Load(object sender, EventArgs e)
        {
            createComputers();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            LoginClientFrm loginEmployeeFrm = new LoginClientFrm(this);

            Button computer = sender as Button;

            this.computerX = int.Parse(computer.Text.Substring(6));
            this.Computer = this.computerController.getById(computerX);

            loginEmployeeFrm.Show();
        }
    }
}
