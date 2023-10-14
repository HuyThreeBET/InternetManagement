using ManagementInternet.Models.Entities;
using System.Data.Entity.Migrations;


namespace ManagementInternet.Controller
{
    internal class UserController
    {
        private readonly InternetManagementContextDB context;

        public UserController()
        {
            this.context = new InternetManagementContextDB();
        }

        public void modify(User obj)
        {
            this.context.Users.AddOrUpdate(obj);
            this.context.SaveChanges();
        }
    }
}
