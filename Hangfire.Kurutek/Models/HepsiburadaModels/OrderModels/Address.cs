using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kurutek.Integration.Models.HepsiburadaModels.OrderModels
{
    public class Address
    {
        public string addressId { get; set; }
        public string address { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string countryCode { get; set; }
        public string phoneNumber { get; set; }
        public string alternatePhoneNumber { get; set; }
        public string district { get; set; }
        public string city { get; set; }
        public string town { get; set; }
    }
}
