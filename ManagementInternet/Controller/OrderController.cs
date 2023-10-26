using ManagementInternet.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Windows.Forms;

namespace ManagementInternet.Controller
{
    internal class OrderController
    {
        public List<Order> getAll()
        {
            InternetManagementContextDB context = new InternetManagementContextDB();

            return context.Orders.ToList();
        }

        public void modify(Order order)
        {
            try
            {
                InternetManagementContextDB context = new InternetManagementContextDB();

                context.Orders.AddOrUpdate(order);
                context.SaveChanges();
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException ex)
            {
                // Handle the validation exception
                foreach (var validationErrors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        MessageBox.Show($"Property: {validationError.PropertyName}");
                        MessageBox.Show($"Error: {validationError.ErrorMessage}");
                    }
                }
            }
        }

        public List<Order> getOrdersByRange(DateTime startDay, DateTime endDay)
        {
            InternetManagementContextDB context = new InternetManagementContextDB();

            return context.Orders.Where(order => order.CreateAt >= startDay && order.CreateAt <= endDay && order.Status == true).ToList();
        }
    }
}

