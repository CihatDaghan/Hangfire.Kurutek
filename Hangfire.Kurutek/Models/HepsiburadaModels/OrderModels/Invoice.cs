using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kurutek.Integration.Models.HepsiburadaModels.OrderModels
{
    public class Invoice
    {
        public string turkishIdentityNumber { get; set; }
        public string taxNumber { get; set; }
        public string taxOffice { get; set; }
        public Address address { get; set; }
    }
}
