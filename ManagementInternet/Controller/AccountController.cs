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

        public bool checkDuplicaton(string id)
        {
            InternetManagementContextDB context = new InternetManagementContextDB();

            Account account = context.Accounts.FirstOrDefault(ac => ac.Id.Equals(id));

            return account != null;
        }

        public Account getByAccountName(string accountName)
        {
            InternetManagementContextDB context = new InternetManagementContextDB();

            Account account = context.Accounts.FirstOrDefault(ac => ac.AccountName.Equals(accountName));

            return account;
        }

        public Account getById(string id)
        {
            InternetManagementContextDB context = new InternetManagementContextDB();

            Account account = context.Accounts.FirstOrDefault(ac => ac.Id.Equals(id));

            return account;
        }

        public void modify(Account account)
        {
            InternetManagementContextDB context = new InternetManagementContextDB();

            context.Accounts.AddOrUpdate(account);
            context.SaveChanges();
        }
    }
}
