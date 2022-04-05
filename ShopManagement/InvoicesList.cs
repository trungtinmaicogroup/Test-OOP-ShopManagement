using ShopManagement.trungtin.invoices;
using ShopManagement.trungtin.products.airconditioners;
using ShopManagement.trungtin.products.fans;
using ShopManagement.trungtin.utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ShopManagement
{
    internal class InvoicesList : List<Invoices>
    {
        public void printMenu()
        {
            Console.Clear();
            Console.WriteLine("******************************************************́́́***************");
            Console.WriteLine("*   Welcome to my Shop                                              *");
            Console.WriteLine("*   Select the option bellow (1 ~ 3):                               *");
            Console.WriteLine("*   1. Show all invoices.                                           *");
            Console.WriteLine("*   2. Add invoice.                                                 *");
            Console.WriteLine("*   3. Quit.                                                        *");
            Console.WriteLine("*********************************************************************́́́́́");
        }

        public void addInvoice()
        {
            const string ID_REGEX = "^IN[0-9]{3}$";
            do
            {
                string id = MyIO.getRegexString(ID_REGEX, "+ Input invoice ID (INXXX - X stands for a number): ", "ID is invalid! Please try again!");
                if (getInvoice(id) == null)
                {
                    this.Add(new Invoices(id));
                    saveFile();
                    MyIO.changeColor("Add successfully! Please wait 2 seconds!", ConsoleColor.Blue);
                    Thread.Sleep(2000);
                    return;
                }
                else
                {
                    MyIO.changeColor("This ID is duplicated! Please try again!\n", ConsoleColor.Red);
                }
            } while (true);
        }
        public void showInvoces()
        {
            if (this.Count > 0)
            {
                Console.Clear();
                Console.WriteLine("Invoice Details: ");
                ConsoleKeyInfo inputKey;
                int index = 0;
                this[index].display();
                Console.WriteLine("");
                do
                {
                    Console.WriteLine($"\t\t\t{index + 1} / {this.Count}");
                    Console.WriteLine(" Press <- or -> to see more.., others to back!");
                    inputKey = Console.ReadKey(false);
                    if (inputKey.Key == ConsoleKey.LeftArrow)
                    {
                        Console.Clear();
                        if (index > 0)
                        {
                            index--;
                            Console.WriteLine("Invoice Details: ");
                            this[index].display();
                        }
                        else if (index == 0)
                        {
                            index = this.Count - 1;
                            Console.WriteLine("Invoice Details: ");
                            this[index].display();
                        }

                    }
                    else if (inputKey.Key == ConsoleKey.RightArrow)
                    {
                        Console.Clear();
                        if (index < this.Count - 1)
                        {
                            index++;
                            Console.WriteLine("Invoice Details: ");
                            this[index].display();
                        }
                        else if (index == this.Count - 1)
                        {
                            index = 0;
                            Console.WriteLine("Invoice Details: ");
                            this[index].display();
                        }
                    }
                    Console.WriteLine("");
                    if (!(inputKey.Key == ConsoleKey.RightArrow || inputKey.Key == ConsoleKey.LeftArrow))
                    {
                        MyIO.changeColor("Back to menu! Please wait 2 seconds", ConsoleColor.Blue);
                        Thread.Sleep(2000);
                    }
                } while (inputKey.Key == ConsoleKey.RightArrow || inputKey.Key == ConsoleKey.LeftArrow);
            }
            else
            {
                Console.WriteLine("Empty! Press any key to back to menu");
                ConsoleKeyInfo key = Console.ReadKey(false);
                if (key != null)
                {
                    MyIO.changeColor("Back to menu! Please wait 2 seconds", ConsoleColor.Blue);
                    Thread.Sleep(2000);
                }
            }
        }
        public Invoices getInvoice(string id)
        {
            foreach (Invoices inv in this)
            {
                if (id.Equals(inv.Id))
                {
                    return inv;
                }
            }
            return null;
        }

        public void saveFile()
        {
            File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\danh_sach_hoa_don.txt", "");

            for (int i = 0; i < this.Count; i++)
            {
                StreamWriter sw = File.AppendText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\danh_sach_hoa_don.txt");
                sw.WriteLine("No: " + (i + 1) + ": ");
                sw.Close();
                this[i].saveFile();
            }

        }
    }
}
