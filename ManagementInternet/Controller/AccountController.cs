using ManagementInternet.Models.Entities;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;


namespace ManagementInternet.Controller
{
    internal class AccountController
    {
        public List<Account> getAll()
        {
            InternetManagementContextDB context = new InternetManagementContextDB();

            return context.Accounts.ToList();
        }

        public List<Account> getAllUser()
        {
            InternetManagementContextDB context = new InternetManagementContextDB();

            return context.Accounts.Where(account => account.RoleId == 1).ToList();
        }

        public bool getById(string id)
        {
            InternetManagementContextDB context = new InternetManagementContextDB();
            Account account = context.Accounts.FirstOrDefault(ac => ac.Id.Equals(id));

            return account != null;
        }

        public void modify(Account obj)
        {
            InternetManagementContextDB context = new InternetManagementContextDB();
            context.Accounts.AddOrUpdate(obj);
            context.SaveChanges();
        }
    }
}
