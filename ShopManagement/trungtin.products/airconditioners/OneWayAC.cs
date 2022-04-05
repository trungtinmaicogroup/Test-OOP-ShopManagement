using ShopManagement.trungtin.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.trungtin.products.airconditioners
{
    public class OneWayAC : AirConditioners
    {
        private const string ID_REGEX = "^ACO[0-9]{3}$";
        public OneWayAC() { input(); }
        public OneWayAC(string _id, string _name, string _placeOfProduction, bool _hasInverter) : base(_id, _name, _placeOfProduction, _hasInverter)
        {
            this._price = this._hasInverter ? 1500 : 1000;
        }
        public void input()
        {
            this._id = MyIO.getRegexString(ID_REGEX, "\t\t + Input 1-way AC ID (ACOXXX - X stands for a number): ", "\t\t ID is invalid! Please try again!");
            this._name = "1-way Air Conditioner";
            this._placeOfProduction = MyIO.getString("\t\t + Input Place of Production: ", "\t\t Place of Production cannot be empty! Please try again!");
            this._hasInverter = MyIO.getBool('y', 'n', "\t\t + Is this AC has Converter (y/n): ", "\t\t You must type y or n! Please try again!");
            this._price = this._hasInverter ? 1500 : 1000;
        }
    }
}
