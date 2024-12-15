using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.EntityConfig
{
    public class SaleConfig : IEntityTypeConfiguration<Sale>
    {
        public void Configure(EntityTypeBuilder<Sale> builder)
        {
            builder.ToTable("Sale");
            builder.HasKey(x => x.SaleId);
            builder.Property(x => x.SaleId).ValueGeneratedOnAdd();

            builder.Property(x => x.TotalPay).IsRequired();
            builder.Property(x => x.SubTotal).IsRequired();
            builder.Property(x => x.TotalDiscount).IsRequired();
            builder.Property(x => x.Taxes).IsRequired();

            //SaleData.SeedData(builder);
        }
    }
}