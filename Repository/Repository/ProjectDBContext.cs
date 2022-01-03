using Microsoft.EntityFrameworkCore;
using Repository.Models;
using Repository.Models.Account;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repository
{
    public class ProjectDBContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=NIKITA-PC;Database=Project;Trusted_Connection=True;MultipleActiveResultSets=true");

            base.OnConfiguring(optionsBuilder);
        }

        public ProjectDBContext(DbContextOptions<ProjectDBContext> options) : base(options)
        {
        }
        public ProjectDBContext()
        {
            Database.EnsureCreated();
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<Bank> Bank { get; set; }
        public DbSet<BankCurrencySB> BankCurrencySB { get; set; }
        public DbSet<DateNow> DateNow { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Account>().ToTable("Account");
            builder.Entity<Currency>().ToTable("Currency");
            builder.Entity<Bank>().ToTable("Bank");
            builder.Entity<BankCurrencySB>().ToTable("BankCurrencySB");
            builder.Entity<DateNow>().ToTable("DateNow");
        }
    }
}
