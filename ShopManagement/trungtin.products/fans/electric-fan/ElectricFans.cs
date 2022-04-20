using ShopManagement.trungtin.fans;
using ShopManagement.trungtin.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.trungtin.products.fans
{
    internal class ElectricFans : Fans
    {
        private double _batteryCapacity;
        private const string ID_REGEX = "^ELF[0-9]{3}$";

        public ElectricFans() { input(); }
        public ElectricFans(string id, string name, string placeOfProduction, double batteryCapacity) : base(id, name, placeOfProduction)
        {
            BatteryCapacity = batteryCapacity;
            this._price = batteryCapacity * 500;
        }
        public double BatteryCapacity
        {
            get => _batteryCapacity;
            set => _batteryCapacity = value;
        }
        public void input()
        {
            this._id = MyIO.getRegexString(ID_REGEX, "\t\t + Input Electric Fan ID (ELFXXX - X stands for a number): ", "\t\t ID is invalid! Please try again!");
            this._name = "Electric Fan";
            this._placeOfProduction = MyIO.getString("\t\t + Input Place of Production: ", "\t\t Place of Production cannot be empty! Please try again!");
            this._batteryCapacity = MyIO.getDouble(0, "\t\t + Input Water Capacity: ", "\t\t Water Capacity must be >0");
            this._price = _batteryCapacity * 500;
        }
    }
}
