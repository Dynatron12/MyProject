using Microsoft.EntityFrameworkCore;
using Project.Models.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{
    public class ProjectDbContext : DbContext
    {
        public ProjectDbContext(DbContextOptions<ProjectDbContext> options) : base(options)
        {
        }

        public DbSet<Account.Account> Accounts { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<Bank> Bank { get; set; }
        public DbSet<BankCurrencySB> BankCurrencySB { get; set; }
        public DbSet<DateNow> DateNow { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Account.Account>().ToTable("Account");
            builder.Entity<Currency>().ToTable("Currency");
            builder.Entity<Bank>().ToTable("Bank");
            builder.Entity<BankCurrencySB>().ToTable("BankCurrencySB");
            builder.Entity<DateNow>().ToTable("DateNow");
        }
    }
}
