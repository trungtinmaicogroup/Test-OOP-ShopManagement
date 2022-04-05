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
        public AirConditioners(string _id, string _name, string _placeOfProduction, bool _hasInverter) : base(_id, _name, _placeOfProduction)
        {
            Inverter = _hasInverter;
        }
        public bool Inverter
        {
            get => _hasInverter;
            set => _hasInverter = value;
        }
    }
}
