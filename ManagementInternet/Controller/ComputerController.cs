using ManagementInternet.Models.Entities;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;


namespace ManagementInternet.Controller
{
    internal class ComputerController
    {
        public List<Computer> getAll()
        {
            InternetManagementContextDB context = new InternetManagementContextDB();

            return context.Computers.ToList();  
        }

        public Computer getById(int id) {
            InternetManagementContextDB context = new InternetManagementContextDB();

            return context.Computers.FirstOrDefault(computer => computer.Id == id);
        }

        public void modify(Computer computer)
        {
            InternetManagementContextDB context = new InternetManagementContextDB();

            context.Computers.AddOrUpdate(computer);    
            context.SaveChanges();
        }
    }
}
