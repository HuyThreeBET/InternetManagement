using ManagementInternet.Controller;
using ManagementInternet.Models.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ManagementInternet.View.Working.Management
{
    public partial class RevenueFrm : Form
    {
        private OrderController orderController;
        private DepositHistoryController depositHistoryController;

        public RevenueFrm()
        {
            this.orderController = new OrderController();
            this.depositHistoryController = new DepositHistoryController(); 

            InitializeComponent();
        }

        private void getDepositHistoriesIntoDgv(List<DepositHistory> depositHistories)
        {
            this.dgvDepositeHistory.Rows.Clear();

            foreach (DepositHistory depositHistory in depositHistories)
            {
                int index = this.dgvDepositeHistory.Rows.Add();

                this.dgvDepositeHistory.Rows[index].Cells[0].Value = depositHistory.Id.ToString();
                this.dgvDepositeHistory.Rows[index].Cells[1].Value = depositHistory.User.Account.AccountName;
                this.dgvDepositeHistory.Rows[index].Cells[2].Value = depositHistory.DepositAmount.ToString();
                this.dgvDepositeHistory.Rows[index].Cells[3].Value = depositHistory.CreateAt.ToString();
            }
        }

        private void getOrdersIntoDgv(List<Order> orders)
        {
            this.dgvRevenueStatisticsOrder.Rows.Clear();

            foreach (Order order in orders)
            {
                int index = this.dgvRevenueStatisticsOrder.Rows.Add();

                string computerId = "Máy số " + order.Computer.Id.ToString();

                this.dgvRevenueStatisticsOrder.Rows[index].Cells[0].Value = computerId;
                this.dgvRevenueStatisticsOrder.Rows[index].Cells[1].Value = order.NameOfDish;
                this.dgvRevenueStatisticsOrder.Rows[index].Cells[2].Value = order.Dish.Price.ToString();
                this.dgvRevenueStatisticsOrder.Rows[index].Cells[3].Value = order.Quantity.ToString();

                int totalAmount = order.Quantity * order.Dish.Price;
                string totalAmoutString = totalAmount.ToString();

                this.dgvRevenueStatisticsOrder.Rows[index].Cells[4].Value = totalAmoutString;
                this.dgvRevenueStatisticsOrder.Rows[index].Cells[5].Value = order.CreateAt.ToString();

                string status = "Đã phục vụ";

                if (!order.Status)
                {
                    status = "Không phục vụ";
                }

                this.dgvRevenueStatisticsOrder.Rows[index].Cells[6].Value = status;
            }
        }

        private void getALlDepositHistoriesIntoDgv()
        {
            List<DepositHistory> depositHistories = this.depositHistoryController.getAll();

            getDepositHistoriesIntoDgv(depositHistories);
        }

        private void getAllOrdersIntoDgv()
        {
            List<Order> orders = this.orderController.getAll();

            getOrdersIntoDgv(orders);
        }

        private void RevenueFrm_Load(object sender, EventArgs e)
        {
            getALlDepositHistoriesIntoDgv();
            getAllOrdersIntoDgv();
        }

        private void btnRevenueStatisticsOrder_Click(object sender, EventArgs e)
        {
            DateTime startDay = this.dateTimePickerStartDate.Value.Date;
            DateTime endDay = this.dateTimePickerEndDate.Value.Date;

            List<Order> orders = this.orderController.getOrdersByRange(startDay, endDay);

            getOrdersIntoDgv(orders);
        }

        private void btnRevenueOrder_Click(object sender, EventArgs e)
        {
            DateTime startDay = this.dateTimePickerStartDate.Value.Date;
            DateTime endDay = this.dateTimePickerEndDate.Value.Date;

            List<Order> orders = this.orderController.getOrdersByRange(startDay, endDay);

            int totalAmount = 0;

            foreach (Order order in orders) {
                totalAmount = totalAmount + (int)order.TotalAmount;
            }

            this.txtRevenue.Text = totalAmount.ToString() + ".000 VND";
        }

        private void btnRevenueStatisticsOrderR_Click(object sender, EventArgs e)
        {
            DateTime startDay = this.dateTimePickerStartDateR.Value.Date;
            DateTime endDay = this.dateTimePickerEndDateR.Value.Date;

            List<DepositHistory> depositHistories = this.depositHistoryController.getDepositHistoriesByRange(startDay, endDay);

            getDepositHistoriesIntoDgv(depositHistories);   
        }

        private void btnRevenueOrderR_Click(object sender, EventArgs e)
        {
            DateTime startDay = this.dateTimePickerStartDateR.Value.Date;
            DateTime endDay = this.dateTimePickerEndDateR.Value.Date;

            List<DepositHistory> depositHistories = this.depositHistoryController.getDepositHistoriesByRange(startDay, endDay);

            int totalAmount = 0;

            foreach (DepositHistory depositHistory in depositHistories)
            {
                totalAmount = totalAmount + (int)depositHistory.DepositAmount;
            }

            this.txtRevenueR.Text = totalAmount.ToString() + ".000 VND";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.orderController = null;
            this.depositHistoryController = null;
            this.Close();
        }
    }
}
