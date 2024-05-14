using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data;

namespace MVCWithEFCF2.Models
{

    public class CompanyDbContext : DbContext
    {
        public CompanyDbContext() : base("Constr")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<CompanyDbContext>());
        }

        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Customer> Customers { get; set; }

    }
}