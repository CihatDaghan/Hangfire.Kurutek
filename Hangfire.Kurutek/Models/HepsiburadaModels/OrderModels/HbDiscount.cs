using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kurutek.Integration.Models.HepsiburadaModels.OrderModels
{
    public class HbDiscount
    {
        public TotalPrice totalPrice { get; set; }
        public UnitPrice unitPrice { get; set; }
    }
}
