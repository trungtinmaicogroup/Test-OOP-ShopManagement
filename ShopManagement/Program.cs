using ShopManagement.trungtin.utils;
using ShopManagement.trungtin.invoices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
                choice = MyIO.getInt(1, 4, "Enter your choice: ");
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
                            Console.WriteLine("\n--------------------------------");
                            list.saveFile();
                            
                            Console.WriteLine("\n--------------------------------");
                            break;
                        }  
                    case 4:
                        {                        
                            MyIO.changeColor("Bye bye!!!~~\nSee you again!!~~~",ConsoleColor.Blue);
                            Thread.Sleep(2000);
                            break;
                        }
                                        }
            } while (choice != 4);
            Console.ReadKey();
        }
    }
}
