using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class SaleProduct
    {
        public int ShoppingCartId { get; set; }
        public int Quantity {get; set;}
        public decimal Price {get; set;}
        public int Discount {get; set; }

        public int SaleId {get; set; }
        public Sale? Sale {get; set; }


        public Guid ProductId {get; set; }
        public Product? Product {get; set; }
    }
}