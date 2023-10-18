using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ManagementInternet.Models.Entities
{
    public partial class InternetManagementContextDB : DbContext
    {
        public InternetManagementContextDB()
            : base("name=InternetManagementContextDB")
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Computer> Computers { get; set; }
        public virtual DbSet<ComputerType> ComputerTypes { get; set; }
        public virtual DbSet<Dish> Dishes { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<PlayTimeManagement> PlayTimeManagements { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Staff> Staffs { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<OrderList> OrderLists { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .Property(e => e.Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.AccountName)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.Passowrd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .HasOptional(e => e.Staff)
                .WithRequired(e => e.Account);

            modelBuilder.Entity<Account>()
                .HasOptional(e => e.User)
                .WithRequired(e => e.Account);

            modelBuilder.Entity<Computer>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.Computer)
                .HasForeignKey(e => e.IdOfComputer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Computer>()
                .HasMany(e => e.PlayTimeManagements)
                .WithRequired(e => e.Computer)
                .HasForeignKey(e => e.IdOfComputer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ComputerType>()
                .HasMany(e => e.Computers)
                .WithOptional(e => e.ComputerType1)
                .HasForeignKey(e => e.ComputerType);

            modelBuilder.Entity<Dish>()
                .HasMany(e => e.Orders)
                .WithOptional(e => e.Dish)
                .HasForeignKey(e => e.NameOfDish);

            modelBuilder.Entity<Order>()
                .HasMany(e => e.OrderLists)
                .WithRequired(e => e.Order)
                .HasForeignKey(e => e.IdOfOrder)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Order>()
                .HasMany(e => e.OrderLists1)
                .WithRequired(e => e.Order1)
                .HasForeignKey(e => e.IdOfOrder)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PlayTimeManagement>()
                .Property(e => e.IdOfUser)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PlayTimeManagement>()
                .HasMany(e => e.OrderLists)
                .WithRequired(e => e.PlayTimeManagement)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.Accounts)
                .WithRequired(e => e.Role)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Staff>()
                .Property(e => e.Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Balance)
                .HasPrecision(10, 3);

            modelBuilder.Entity<User>()
                .HasMany(e => e.PlayTimeManagements)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.IdOfUser)
                .WillCascadeOnDelete(false);
        }
    }
}
