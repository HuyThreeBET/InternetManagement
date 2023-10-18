using ManagementInternet.Models.Entities;
using System.Collections.Generic;
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
    }
}
