using ShopManagement.trungtin.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ShopManagement.trungtin.products
{
    public class Products
    {
        protected string _id;
        protected string _name;
        protected string _placeOfProduction;
        protected double _price;
        public Products()
        {

        }
        public Products(string _id, string _name, string _placeOfProduction)
        {
            Id = _id;
            Name = _name;
            PlaceOfProduction = _placeOfProduction;
        }

        public string Id
        {
            get => _id;
            set => _id = value;
        }
       
        public string Name
        {
            get => _name;
            set => _name = value;
        }
        public string PlaceOfProduction
        {
            get => _placeOfProduction;
            set => _placeOfProduction = value;
        }
        public double Price
        {
            get => _price;
            set => _price = value;
        }
    }


}

