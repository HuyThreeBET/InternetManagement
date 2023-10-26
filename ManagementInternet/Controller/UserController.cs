using ManagementInternet.Models.Entities;
using System.Data.Entity.Migrations;
using System.Linq;

namespace ManagementInternet.Controller
{
    internal class UserController
    {
        public void modify(User obj)
        {
            InternetManagementContextDB context = new InternetManagementContextDB();

            context.Users.AddOrUpdate(obj);
            context.SaveChanges();
        }

        public User getByAccountname(string accountname)
        {
            InternetManagementContextDB context = new InternetManagementContextDB();

            return context.Users.FirstOrDefault(user => user.Account.AccountName.Equals(accountname));
        }
    }
}
