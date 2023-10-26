using ManagementInternet.Controller;
using ManagementInternet.Models.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ManagementInternet.View.Client
{
    public partial class OrderServiceFrm : Form
    {
        private DishController dishController;
        private OrderController orderController;
        private MainScreenFrm mainScreenFrm;
        private Dish dish;
        //private SocketManagemant socket;
        //private bool got = false;
        private int quantity = 0;

        public OrderServiceFrm(MainScreenFrm mainScreenFrm)
        {
            this.dishController = new DishController();
            this.orderController = new OrderController();
            this.mainScreenFrm = mainScreenFrm;
            this.dish = null;
            //this.socket = new SocketManagemant();

            InitializeComponent();
        }

        private void getServiceIntoDgv()
        {
            this.dgvService.Rows.Clear();

            List<Dish> dishes = this.dishController.getAllWithStatusTrue();

            foreach (Dish dish in dishes)
            {
                int index = this.dgvService.Rows.Add();

                this.dgvService.Rows[index].Cells[0].Value = dish.Name;
                this.dgvService.Rows[index].Cells[1].Value = dish.Type;
                this.dgvService.Rows[index].Cells[2].Value = dish.Price.ToString();
            }
        }

        //private void connect()
        //{
        //    this.socket.ConnectServer();
        //}

        private void OrderServiceFrm_Load(object sender, EventArgs e)
        {
            //if (!got)
            //{
            //    // Get ip in 2 ways
            //    // Wifi
            //    this.socket.Ip = socket.GetLocalIPv4(NetworkInterfaceType.Wireless80211);

            //    if (string.IsNullOrEmpty(this.socket.Ip))
            //    {
            //        // Ethernet
            //        socket.Ip = socket.GetLocalIPv4(NetworkInterfaceType.Ethernet);
            //    }

            //    got = true;
            //}

            //connect();
            getServiceIntoDgv();
        }

        private void dgvService_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = (int)e.RowIndex;

                string nameService = this.dgvService.Rows[index].Cells[0].Value.ToString();

                this.dish = this.dishController.getByName(nameService);
                this.btnAdd.Enabled = true;

                if (this.dish == null)
                {
                    MessageBox.Show("null");
                }

                byte[] imageData = (byte[])dish.Image;

                MemoryStream ms = new MemoryStream(imageData);

                this.pictureBox.Image = Image.FromStream(ms);
            }
            catch
            {
                MessageBox.Show("Bạn đã nhấp vào ô không hợp lệ");
            }
        }

        //private void sendOrder(Order order)
        //{
        //    this.socket.Send(order);
        //}

        private void setDefaultFields()
        {
            this.pictureBox.Image = null;
            this.quantity = 0;
            this.txtQuantity.Text = this.quantity.ToString();
            this.txtTotalAmount.Text = "0.000 VND";
            this.dish = null;
        }

        private int caculate()
        {
            return this.quantity * this.dish.Price;
        }

        private void minus()
        {
            if (this.quantity == 0)
            {
                this.btnMinus.Enabled = false;
                this.txtTotalAmount.Text = "0.000 VND";
            }
            else
            {
                this.quantity--;
                this.txtQuantity.Text = this.quantity.ToString();
                this.txtTotalAmount.Text = caculate().ToString() + ".000 VND";
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            minus();
        }

        private void add()
        {
            if (this.quantity != 0)
            {
                this.btnMinus.Enabled = true;
            }

            this.quantity++;
            this.txtQuantity.Text = this.quantity.ToString();
            this.txtTotalAmount.Text = caculate().ToString() + ".000 VND";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            add();
        }

        private void order()
        {
            Order order = new Order();

            if (this.dish == null)
            {
                MessageBox.Show("Order không hợp lệ");

                return;
            }

            short idOfComputer = this.mainScreenFrm.LoginClientFrm.ComputersFrm.ComputerX;
            string nameOfDish = this.dish.Name;
            short quantity = short.Parse(this.txtQuantity.Text);
            short totalAmount = (short)(this.dish.Price * quantity);

            order.IdOfComputer = idOfComputer;
            order.NameOfDish = nameOfDish;
            order.Quantity = quantity;
            order.TotalAmount = totalAmount;
            order.CreateAt = DateTime.Now;
            order.Status = true;
            order.Note = "Đã phục vụ";

            if (quantity == 0)
            {
                MessageBox.Show("Số lượng không hợp lệ");

                return;
            }

            this.orderController.modify(order);
            this.mainScreenFrm.TotalAmountService += totalAmount;
            this.mainScreenFrm.setTotalAmountServie();
            MessageBox.Show("Đặt thành công");
            //sendOrder(order);
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            order();
            setDefaultFields();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.dishController = null;
            this.orderController = null;
            this.mainScreenFrm = null;
            this.dish = null;
            this.Close();
        }
    }
}
