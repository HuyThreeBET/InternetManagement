using ManagementInternet.Models.Entities;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace ManagementInternet.Controller
{
    internal class DishController
    {
        public List<Dish> getAll()
        {
            InternetManagementContextDB context = new InternetManagementContextDB();

            return context.Dishes.ToList();
        }

        public List<Dish> getAllWithStatusTrue()
        {
            InternetManagementContextDB context = new InternetManagementContextDB();

            return context.Dishes.Where(dish => dish.State == true).ToList();
        }

        public List<Dish> getAllByTypeOfService(string typeOfService)
        {
            InternetManagementContextDB context = new InternetManagementContextDB();

            return context.Dishes.Where(type => type.Type.Equals(typeOfService)).ToList();
        }

        public void modify(Dish dish)
        {
            InternetManagementContextDB context = new InternetManagementContextDB();

            context.Dishes.AddOrUpdate(dish);
            context.SaveChanges();
        }

        public void delete(string name)
        {
            InternetManagementContextDB context = new InternetManagementContextDB();

            Dish dish = context.Dishes.FirstOrDefault(service => service.Name.Equals(name));

            context.Dishes.Remove(dish);
            context.SaveChanges();
        }

        public Dish getByName(string name)
        {
            InternetManagementContextDB context = new InternetManagementContextDB();

            return context.Dishes.FirstOrDefault(dish => dish.Name.Equals(name));
        }
    }
}
