using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Configurations
{
    public class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.ToTable("OrderDetails");
            builder.HasKey(s => new { s.OrderId, s.ProductId });
            builder.HasOne(s => s.Order).WithMany(s => s.OrderDetails).HasForeignKey(s => s.OrderId);
            builder.HasOne(s => s.Product).WithMany(s => s.OrderDetails).HasForeignKey(s => s.ProductId);
        }
    }
}
