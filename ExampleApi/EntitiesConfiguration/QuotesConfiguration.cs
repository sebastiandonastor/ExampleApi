using ExampleApi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace ExampleApi.EntitiesConfiguration
{
    public class QuotesConfiguration : EntityTypeConfiguration<Quote>
    {
        public QuotesConfiguration()
        {
                HasKey(q => q.Id);

                Property(q => q.Title)
                .IsRequired()
                .HasMaxLength(20);

                Property(q => q.Type)
                .IsRequired()
                .HasMaxLength(25);


        }
    }
}