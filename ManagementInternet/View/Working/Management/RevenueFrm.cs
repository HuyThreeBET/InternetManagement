using ManagementInternet.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementInternet.View.Working.Management
{
    public partial class RevenueFrm : Form
    {
        private InternetManagementContextDB dbContext = new InternetManagementContextDB();
        private List<Order> listOrder = new List<Order>();
        public RevenueFrm()
        {
            InitializeComponent();        }

        private void btnbtnRevenueStatisticsOrder_Click(object sender, EventArgs e)
        {
            DateTime startDay = dateTimePickerStartDate.Value.Date;
            DateTime endDay = dateTimePickerEndDate.Value.Date;
            var totalRevenue = dbContext.Orders
                .Where(order => order.CreateAt >= startDay && order.CreateAt <= endDay && order.Status == true)
                .Sum(order => order.TotalAmount);
            txtRevenue.Text = totalRevenue.ToString();

        }

        private void btnRevenueStatisticsOrder_Click(object sender, EventArgs e)
        {
            DateTime startDay = dateTimePickerStartDate.Value.Date;
            DateTime endDay = dateTimePickerEndDate.Value.Date;
            var filteredOrders = dbContext.Orders
            .Where(order => order.CreateAt >= startDay && order.CreateAt <= endDay && order.Status == true)
            .ToList();
            dgvRevenueStatisticsOrder.DataSource = new BindingList<Order>(filteredOrders);
        }

      
    }
}
