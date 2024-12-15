using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Product
    {
        public Guid ProductId {get; set;}
        public required string ProductName {get; set;}
        public string? Description {get; set;}
        public decimal Price {get; set;}
        public int Discount {get; set;}

        public int CategoryId {get; set;}
        public Category? Category {get; set;}

        public IList<SaleProduct>? SalesProducts { get; set; }
    }
}