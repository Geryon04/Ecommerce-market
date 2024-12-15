using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.EntityConfig
{
    public class SaleProductConfig : IEntityTypeConfiguration<SaleProduct>
    {
        public void Configure(EntityTypeBuilder<SaleProduct> builder)
        {
            builder.ToTable("SaleProduct");
            builder.HasKey(x => x.ShoppingCartId);
            builder.Property(x => x.ShoppingCartId).ValueGeneratedOnAdd();

            builder.HasOne<Sale>(x => x.Sale)
            .WithMany(x => x.SalesProducts)
            .HasForeignKey(x => x.SaleId);

            builder.HasOne<Product>(x => x.Product)
            .WithMany(x => x.SalesProducts)
            .HasForeignKey(x => x.ProductId);
        }
    }
}