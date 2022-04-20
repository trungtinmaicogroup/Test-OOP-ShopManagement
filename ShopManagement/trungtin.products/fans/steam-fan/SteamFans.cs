using ShopManagement.trungtin.fans;
using ShopManagement.trungtin.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.trungtin.products.fans
{
    internal class SteamFans : Fans
    {
        private double _waterCapacity;
        private const string ID_REGEX = "^SMF[0-9]{3}$";

        public SteamFans() { input(); }
        public SteamFans(string id, string name, string placeOfProduction, double waterCapacity) : base(id, name, placeOfProduction)
        {
            WaterCapacity = waterCapacity;
            this._price = waterCapacity * 400;
        }
        public double WaterCapacity
        {
            get => _waterCapacity;
            set => _waterCapacity = value;
        }
        public void input()
        {
            this._id = MyIO.getRegexString(ID_REGEX, "\t\t + Input Steam Fan ID (SMFXXX - X stands for a number): ", "\t\t ID is invalid! Please try again!");
            this._name = "Steam Fan";
            this._placeOfProduction = MyIO.getString("\t\t + Input Place of Production: ", "\t\t Place of Production cannot be empty! Please try again!");
            this._waterCapacity = MyIO.getDouble(0, "\t\t + Input Water Capacity: ", "\t\t Water Capacity must be >0");
            this._price = _waterCapacity * 400;
        }
    }
}
