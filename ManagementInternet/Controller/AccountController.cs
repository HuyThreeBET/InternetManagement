using ManagementInternet.Models.Entities;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;


namespace ManagementInternet.Controller
{
    internal class AccountController
    {
        private readonly InternetManagementContextDB context;

        public AccountController()
        {
            this.context = new InternetManagementContextDB();
        }

        public List<Account> getAll()
        {
            return this.context.Accounts.ToList();
        }

        public List<Account> getAllUser()
        {
            return this.context.Accounts.Where(account => account.RoleId == 1).ToList();
        }

        public bool getById(string id)
        {
            Account account = this.context.Accounts.FirstOrDefault(ac => ac.Id.Equals(id));

            return account != null;
        }

        public void modify(Account obj)
        {
            this.context.Accounts.AddOrUpdate(obj);
            this.context.SaveChanges();
        }
    }
}
