using ManagementInternet.Models.Entities;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace ManagementInternet.Controller
{
    internal class TypeOfDishController
    {
        public List<TypeOfDish> getAll()
        {
            InternetManagementContextDB context = new InternetManagementContextDB();

            return context.TypeOfDishes.ToList();
        }

        public TypeOfDish getByName(string name)
        {
            InternetManagementContextDB context = new InternetManagementContextDB();

            return context.TypeOfDishes.FirstOrDefault(type => type.Name.Equals(name));
        }

        public void add(TypeOfDish typeOfDish)
        {
            InternetManagementContextDB context = new InternetManagementContextDB();

            context.TypeOfDishes.AddOrUpdate(typeOfDish);
            context.SaveChanges();
        }

        public void delete(string name)
        {
            InternetManagementContextDB context = new InternetManagementContextDB();

            TypeOfDish typeOfDish = context.TypeOfDishes.FirstOrDefault(type => type.Name.Equals(name));

            context.TypeOfDishes.Remove(typeOfDish);
            context.SaveChanges();
        }
    }
}
