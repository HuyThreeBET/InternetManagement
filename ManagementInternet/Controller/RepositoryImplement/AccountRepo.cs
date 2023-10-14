using ManagementInternet.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementInternet.Controller.RepositoryImplement
{
    internal class AccountRepo : IRepositoryBase<Account>
    {
        private readonly Context context;

        public AccountRepo(Context context)
        {
            this.context = context;
        }

        public void deleteById(Account obj)
        {
            this.context.Accounts.Remove(obj);
            this.context.SaveChanges();
        }

        public List<Account> getAll()
        {
            return this.context.Accounts.ToList();
        }

        public Account getByName(string name)
        {
            return this.context.Accounts.FirstOrDefault(account => account.AccountName.Equals(name));
        }

        public void modify(Account obj)
        {
            this.context.Accounts.AddOrUpdate(obj);
            this.context.SaveChanges();
        }
    }
}
