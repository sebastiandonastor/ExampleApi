using ExampleApi.EntitiesConfiguration;
using ExampleApi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ExampleApi.Data
{
    public class PassageDbContext : DbContext
    {
      public DbSet<Quote> Quotes { get; set; }
        public PassageDbContext() : base("PassageConnection")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new QuotesConfiguration());
        }
    }
}