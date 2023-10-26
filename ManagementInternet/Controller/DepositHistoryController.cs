using ManagementInternet.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace ManagementInternet.Controller
{
    internal class DepositHistoryController
    {
        public List<DepositHistory> getAll()
        {
            InternetManagementContextDB context = new InternetManagementContextDB();

            return context.DepositHistories.ToList();   
        }

        public void modify(DepositHistory depositHistory)
        {
            InternetManagementContextDB context = new InternetManagementContextDB();

            context.DepositHistories.AddOrUpdate(depositHistory);   
            context.SaveChanges();
        }

        public List<DepositHistory> getDepositHistoriesByRange(DateTime startDay, DateTime endDay)
        {
            InternetManagementContextDB context = new InternetManagementContextDB();

            return context.DepositHistories.Where(depositHistory => depositHistory.CreateAt >= startDay && depositHistory.CreateAt <= endDay).ToList();
        }
    }
}
