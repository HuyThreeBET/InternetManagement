using ManagementInternet.Controller;
using ManagementInternet.Models.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ManagementInternet.View.Client
{
    public partial class ComputersFrm : Form
    {
        private ComputerController computerController;
        private List<Computer> computers;
        private Computer computer;
        private Button selectingComputer;
        private short computerX;

        public short ComputerX { get => computerX; set => computerX = value; }
        public Computer Computer { get => computer; set => computer = value; }
        public Button SelectingComputer { get => selectingComputer; set => selectingComputer = value; }
        internal ComputerController ComputerController { get => computerController; set => computerController = value; }

        public ComputersFrm()
        {
            this.ComputerController = new ComputerController();
            this.computers = null;
            this.Computer = null;

            InitializeComponent();
        }

        private void createComputers()
        {
            this.computers = this.ComputerController.getAll();

            foreach (Computer computer in computers)
            {
                Button button = new Button()
                {
                    Width = 230,
                    Height = 57
                };

                string computerName = "Máy số " + computer.Id.ToString();

                if (computer.State)
                {
                    button.BackColor = Color.AliceBlue;
                    button.Enabled = false;
                }

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

            this.SelectingComputer = sender as Button;
            this.computerX = short.Parse(this.SelectingComputer.Text.Substring(6));
            this.Computer = this.ComputerController.getById(computerX);

            loginEmployeeFrm.Show();
        }
    }
}
