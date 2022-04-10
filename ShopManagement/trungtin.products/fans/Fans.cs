using ShopManagement.trungtin.products;
using ShopManagement.trungtin.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ShopManagement.trungtin.fans
{
    public class Fans : Products
    {
        public Fans() { }
        public Fans(string id, string name, string placeOfProduction) : base(id, name, placeOfProduction)
        {

        }
    }
}
