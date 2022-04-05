using ShopManagement.trungtin.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.trungtin.products.airconditioners
{
    public class TwoWayAC : AirConditioners
    {
        private bool _hasDeodorizationTech;
        private bool _hasAntibacterialTech;
        private const string ID_REGEX = "^ACT[0-9]{3}$";

        public TwoWayAC() { input(); }
        public TwoWayAC(string _id, string _name, string _placeOfProduction, bool _hasInverter, bool _hasDeodorizationTech, bool _hasAntibacterialTech) : base(_id, _name, _placeOfProduction, _hasInverter)
        {
            HasDeodorizationTech = _hasDeodorizationTech;
            HasAntibacterialTech = _hasAntibacterialTech;
            this._price = (this._hasInverter ? 2500 : 2000) + (this._hasAntibacterialTech ? 500 : 0) + (this._hasDeodorizationTech ? 500 : 0);
        }
        public bool HasDeodorizationTech
        {
            get => _hasDeodorizationTech;
            set => _hasDeodorizationTech = value;
        }
        public bool HasAntibacterialTech
        {
            get => _hasAntibacterialTech;
            set => _hasAntibacterialTech = value;
        }
        public void input()
        {
            this._id = MyIO.getRegexString(ID_REGEX, "\t\t + Input 2-way AC ID (ACTXXX - X stands for a number): ", "\t\t ID is invalid! Please try again!");
            this._name = "2-way Air Conditioner";
            this._placeOfProduction = MyIO.getString("\t\t + Input Place of Production: ", "\t\t Place of Production cannot be empty! Please try again!");
            this._hasInverter = MyIO.getBool('y', 'n', "\t\t + Is this AC has Converter (y/n): ", "\t\t You must type y or n! Please try again!");
            this._hasDeodorizationTech = MyIO.getBool('y', 'n', "\t\t + Is this AC has Antibacterial Technology (y/n): ", "\t\t You must type y or n! Please try again!");
            this._hasAntibacterialTech = MyIO.getBool('y', 'n', "\t\t + Is this AC has Deodorization Technology (y/n): ", "\t\t You must type y or n! Please try again!");
            this._price = this._hasInverter ? 1500 : 1000;
        }
    }
}
