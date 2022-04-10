using ShopManagement.trungtin.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            InvoicesList list = new InvoicesList();
            do
            {
                list.printMenu();
                choice = MyIO.getInt(1, 3, "Enter your choice: ");
                switch (choice)
                {
                    case 1:
                        {
                            Console.WriteLine("\n--------------------------------");
                            list.showInvoces();
                            Console.WriteLine("--------------------------------\n");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("\n--------------------------------");
                            int numOfInvoices = MyIO.getInt(1, "+  Enter number of Invoice(s): ");
                            for (int i = 0; i < numOfInvoices;)
                            {
                                Console.WriteLine($"-- Invoice {++i}");
                                list.addInvoice();
                            }
                            Console.WriteLine("--------------------------------\n");
                            break;
                        }
                     case 3:
                        {
                            //list.saveFile(fileName);
                            //System.out.println(MyToys.getGreenColor("Your datas have been saved in *" + fileName + "*"));
                            //System.out.println(MyToys.getGreenColor("Bye bye!!!~~\nSee you again!!~~~"));
                            break;
                        }
                }
            } while (choice != 3);
            Console.ReadKey();
        }
    }
}
