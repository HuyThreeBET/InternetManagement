using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ManagementInternet.Entities
{
    public partial class Context : DbContext
    {
        public Context()
            : base("name=Context")
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Computer> Computers { get; set; }
        public virtual DbSet<Dish> Dishes { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<PlayTimeManagement> PlayTimeManagements { get; set; }
        public virtual DbSet<Staff> Staffs { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
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

            modelBuilder.Entity<Dish>()
                .HasMany(e => e.Orders)
                .WithOptional(e => e.Dish)
                .HasForeignKey(e => e.NameOfDish);

            modelBuilder.Entity<PlayTimeManagement>()
                .HasMany(e => e.Orders)
                .WithMany(e => e.PlayTimeManagements)
                .Map(m => m.ToTable("OrderList").MapLeftKey("Id").MapRightKey("IdOfOrder"));

            modelBuilder.Entity<User>()
                .Property(e => e.Balance)
                .HasPrecision(9, 3);

            modelBuilder.Entity<User>()
                .HasMany(e => e.PlayTimeManagements)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);
        }
    }
}