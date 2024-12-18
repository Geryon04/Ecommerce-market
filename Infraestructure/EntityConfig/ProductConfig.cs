using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Infraestructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.EntityConfig
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Product");
            builder.HasKey(x => x.ProductId);
            builder.Property(x => x.ProductId).ValueGeneratedOnAdd();

            builder.Property(x => x.ProductName).HasMaxLength(100).IsRequired();

            builder.Property(x => x.Description).HasMaxLength(255);

            builder.Property(x => x.Price).IsRequired();

            builder.Property(x => x.Discount);

            builder.HasOne<Category>(x => x.Category)
            .WithMany(x => x.Products)
            .HasForeignKey(x => x.CategoryId);

            ProductData.SeedData(builder);
        }
    }
}