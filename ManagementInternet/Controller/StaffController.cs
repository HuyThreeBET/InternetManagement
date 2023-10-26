using ManagementInternet.Models.Entities;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace ManagementInternet.Controller
{
    internal class StaffController
    {
        public List<Staff> getAll()
        {
            InternetManagementContextDB context = new InternetManagementContextDB();

            return context.Staffs.ToList();
        }
        public void modify(Staff staff)
        {
            InternetManagementContextDB context = new InternetManagementContextDB();

            context.Staffs.AddOrUpdate(staff);
            context.SaveChanges();
        }

        public Staff getByAccountName(string accountName)
        {
            InternetManagementContextDB context = new InternetManagementContextDB();


            return context.Staffs.FirstOrDefault(staff => staff.Account.AccountName.Equals(accountName));
        }

        public Staff getById(string id)
        {
            InternetManagementContextDB context = new InternetManagementContextDB();


            return context.Staffs.FirstOrDefault(staff => staff.Id.Equals(id));
        }
    }
}
