using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Sale
    {
        public int SaleId { get; set; }
        public required decimal TotalPay {get; set;}
        public required decimal SubTotal {get; set;}
        public required decimal TotalDiscount {get; set;}
        public required decimal Taxes {get; set;}
        public required DateTime Date { get; set; }

        public IList<SaleProduct>? SalesProducts { get; set; }

    }
}