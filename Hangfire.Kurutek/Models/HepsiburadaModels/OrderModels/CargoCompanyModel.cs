using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kurutek.Integration.Models.HepsiburadaModels
{
    public class CargoCompanyModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public string shortName { get; set; }
        public string logoUrl { get; set; }
        public string trackingUrl { get; set; }
    }
}
