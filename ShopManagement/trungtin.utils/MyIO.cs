using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ShopManagement.trungtin.utils
{
    internal class MyIO
    {
        public static void changeColor(string msg, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(msg);
            Console.ResetColor();
        }

        public static int getInt(int min, int max, string inputMsg, string errorMsg)
        {
            int n;
            do
            {
                try
                {
                    Console.Write(inputMsg);
                    n = int.Parse(Console.ReadLine());
                    if (n >= min && n <= max)
                    {
                        return n;
                    }
                    //changeColor(errorMsg, ConsoleColor.Red);
                    changeColor($"Your input must be a Integer between [{min};{max}]", ConsoleColor.Red);
                }
                catch (Exception e)
                {
                    changeColor(errorMsg, ConsoleColor.Red);
                }
            } while (true);

        }
        public static int getInt(int min, int max, string inputMsg)
        {
            int n;
            do
            {
                try
                {
                    Console.Write(inputMsg);
                    n = int.Parse(Console.ReadLine());
                    if (n >= min && n <= max)
                    {
                        return n;
                    }
                    changeColor($"Your input must be a Integer between [{min};{max}]", ConsoleColor.Red);
                }
                catch (Exception e)
                {
                    changeColor($"Your input must be a Integer between [{min};{max}]", ConsoleColor.Red);
                }
            } while (true);
        }
        public static int getInt(int min, string inputMsg)
        {
            int n;
            do
            {
                try
                {
                    Console.Write(inputMsg);
                    n = int.Parse(Console.ReadLine());
                    if (n >= min)
                    {
                        return n;
                    }
                    changeColor($"Your input must be a Integer >= {min}", ConsoleColor.Red);
                }
                catch (Exception e)
                {
                    changeColor($"Your input must be a Integer >= {min}", ConsoleColor.Red);
                }
            } while (true);
        }
        public static double getDouble(double min, string inputMsg)
        {
            double n;
            do
            {
                try
                {
                    Console.Write(inputMsg);
                    n = double.Parse(Console.ReadLine());
                    if (n >= min)
                    {
                        return n;
                    }
                    changeColor($"Your input must be a Integer >= {min}", ConsoleColor.Red);
                }
                catch (Exception e)
                {
                    changeColor($"Your input must be a Integer >= {min}", ConsoleColor.Red);
                }
            } while (true);
        }
        public static string getRegexString(string regex, string inputMsg, string errorMsg)
        {
            string regexString;
            do
            {
                Console.Write(inputMsg);
                regexString = Console.ReadLine();
                bool check = Regex.IsMatch(regexString.ToUpper().Trim(), regex);
                if (check)
                {
                    return regexString.ToUpper().Trim();
                }
                else
                {
                    changeColor(errorMsg, ConsoleColor.Red);
                }
            } while (true);
        }
        public static DateTime getDate(string inputMsg, string errorMsg)
        {
            string date;
            DateTime dateValue;
            do
            {
                try
                {
                    Console.Write(inputMsg);
                    date = Console.ReadLine();
                    CultureInfo provider = CultureInfo.InvariantCulture;
                    string[] formats = {"dd/MM/yyyy","d/M/yyyy"};
                    dateValue = DateTime.ParseExact(date, formats, provider,DateTimeStyles.None);
                    return dateValue;
                }
                catch (Exception e)
                {
                    changeColor(errorMsg, ConsoleColor.Red);
                }
            } while (true);
        }
        public static string getString(string inputMsg, string errorMsg)
        {
            string s;
            do
            {
                try
                {
                    Console.Write(inputMsg);
                    s = Console.ReadLine();
                    if (s.Trim().Length != 0)
                    {
                        return s.Trim();
                    }
                }
                catch (Exception e)
                {
                    changeColor(errorMsg, ConsoleColor.Red);
                }
            } while (true);
        }
        public static bool getBool(char y, char n, string inputMsg, string errorMsg)
        {
            char s;
            do
            {
                try
                {
                    Console.Write(inputMsg);
                    s = char.Parse(Console.ReadLine());
                    if (s.ToString().ToLower().Equals(y.ToString()) || s.ToString().ToLower().Equals(n.ToString()))
                    {
                        return s.ToString().ToLower().Equals(y.ToString());
                    }
                    else
                    {
                        changeColor(errorMsg, ConsoleColor.Red);
                    }
                }
                catch (Exception e)
                {
                    changeColor(errorMsg, ConsoleColor.Red);
                }
            } while (true);
        }
    }
}