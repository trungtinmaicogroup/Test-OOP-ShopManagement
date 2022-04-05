using ShopManagement.trungtin.fans;
using ShopManagement.trungtin.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.trungtin.products.fans
{
    internal class StandFans : Fans
    {
        private const string ID_REGEX = "^SDF[0-9]{3}$";

        public StandFans() { input(); }
        public StandFans(string _id, string _name, string _placeOfProduction) : base(_id, _name, _placeOfProduction)
        {
            this._price = 500;
        }
        public void input()
        {
            this._id = MyIO.getRegexString(ID_REGEX, "\t\t + Input Stand Fan ID (SDFXXX - X stands for a number): ", "\t\t ID is invalid! Please try again!");
            this._name = "Stand Fan";
            this._placeOfProduction = MyIO.getString("\t\t + Input Place of Production: ", "\t\t Place of Production cannot be empty! Please try again!");
            this._price = 500;
        }
    }
}
