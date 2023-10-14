using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementInternet.Controller
{
    internal interface IRepositoryBase<T>
    {
        List<T> getAll();
        T getByName(string name);
        void modify(T obj);  
        void deleteById(T obj);
    }
}
