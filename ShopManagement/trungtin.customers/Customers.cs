using ShopManagement.trungtin.utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ShopManagement
{
    internal class Customers
    {
        private string _cusID;
        private string _cusName;
        private string _cusAddress;
        private string _cusPhone;
        private const string ID_REGEX = "^CU[0-9]{3}$";
        private const string PHONE_REGEX = "^0[0-9]{9}$";

        public Customers() { input(); }

        public Customers(string cusID, string cusName, string cusAddress, string cusPhone)
        {
            CusID = cusID;
            CusName = cusName;
            CusAddress = cusAddress;
            CusPhone = cusPhone;
        }

        public string CusID
        {
            get => _cusID;
            set
            {
                if (Regex.IsMatch(value, ID_REGEX))
                {
                    _cusID = value;
                }
                else
                {
                    MyIO.changeColor("This ID does not match with the regex HDXXX", ConsoleColor.Red);
                }
            }
        }
        public string CusName
        {
            get => _cusName;
            set => _cusName = value;
        }
        public string CusAddress
        {
            get => _cusAddress;
            set => _cusAddress = value;
        }
        public string CusPhone
        {
            get => _cusID;
            set
            {
                if (Regex.IsMatch(value, PHONE_REGEX))
                {
                    _cusID = value;
                }
                else
                {
                    MyIO.changeColor("This Phone Number is invalid. Please try again!", ConsoleColor.Red);
                }
            }
        }

        public void input()
        {
            Console.WriteLine("+ Customer information: ");
            this._cusID = MyIO.getRegexString(ID_REGEX, "\t + Input Customer ID (CUXXX - X stands for a number): ", "\t ID is invalid! Please try again!");
            this._cusName = MyIO.getString("\t + Input Customer Name: ", "\t Customer Name cannot be empty! Please try again!");
            this._cusAddress = MyIO.getString("\t + Input Customer Address: ", "\t Customer Address cannot be empty! Please try again!");
            this._cusPhone = MyIO.getRegexString(PHONE_REGEX, "\t + Input Customer Phone Number: ", "\t Phone Number is invalid (must have 10 digits)! Please try again!");
        }
        public void saveFile()
        {
            StreamWriter sw = File.AppendText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\danh_sach_hoa_don.txt");
            sw.WriteLine($"Customer Information: {_cusID} - {_cusName} - {_cusAddress} - {_cusPhone}");
            sw.Close();
        }
    }
}
