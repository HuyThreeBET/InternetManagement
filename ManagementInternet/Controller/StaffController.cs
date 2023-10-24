using ManagementInternet.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementInternet.Controller
{
    internal class StaffController
    {
        public void modify(Staff obj)
        {
            InternetManagementContextDB context = new InternetManagementContextDB();
            context.Staffs.AddOrUpdate(obj);
            context.SaveChanges();
        }

        public Staff getByAccountName(string accountName)
        {
            InternetManagementContextDB contextDB = new InternetManagementContextDB();
            return contextDB.Staffs.FirstOrDefault(staff => staff.Account.AccountName.Equals(accountName));
        }
    }
}
