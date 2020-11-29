using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");
            builder.HasKey(s => s.Id);
            builder.Property(s => s.Price).IsRequired();
            builder.Property(s => s.OriginalPrice).IsRequired();
            builder.Property(s => s.Stock).IsRequired();
            builder.Property(s => s.ViewCount).IsRequired().HasDefaultValue(0);
        }
    }
}
