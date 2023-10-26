using ManagementInternet.Models.Entities;
using System.Data.Entity.Migrations;


namespace ManagementInternet.Controller
{
    internal class PlayTimeManagementController
    {
        public void modify(PlayTimeManagement playTimeManagement)
        {
            InternetManagementContextDB context = new InternetManagementContextDB();

            context.PlayTimeManagements.AddOrUpdate(playTimeManagement);
            context.SaveChanges();
        }
    }
}
