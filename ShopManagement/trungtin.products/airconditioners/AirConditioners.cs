using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.trungtin.products.airconditioners
{
    public class AirConditioners : Products
    {
        protected bool _hasInverter;
        public AirConditioners() { 
        
        }
        public AirConditioners(string id, string name, string placeOfProduction, bool hasInverter) : base(id, name, placeOfProduction)
        {
            Inverter = hasInverter;
        }
        public bool Inverter
        {
            get => _hasInverter;
            set => _hasInverter = value;
        }
    }
}
