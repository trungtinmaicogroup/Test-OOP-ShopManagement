using ShopManagement.trungtin.products;
using ShopManagement.trungtin.products.airconditioners;
using ShopManagement.trungtin.products.fans;
using ShopManagement.trungtin.utils;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.trungtin.invoices
{
    internal class Invoices
    {
        private string _id;
        private DateTime _date;
        private Customers _customer;
        private List<InvoiceDetails> _invoiceDetailsList = new List<InvoiceDetails>();
        private double _total = 0;

        public Invoices(String id)
        {
            this._id = id;
            input();
        }
        public string Id
        {
            get => _id;
        }

        public void input()
        {
            this._date = MyIO.getDate("+ Input Date (dd/MM/yyyy): ", "Date is invalid! Please try again!");
            this._customer = new Customers();
            int numOfProduct = MyIO.getInt(1, "+  Enter number of Product(s): ");
            for (int i = 0; i < numOfProduct;)
            {
                Console.WriteLine($"\t Product {++i}");
                InvoiceDetails invoiceDetails = addProduct();
                _invoiceDetailsList.Add(invoiceDetails);
                _total += invoiceDetails.Total;
            }
        }
        public void display()
        {
            Console.WriteLine($"Invoice ID: {_id,-20} \t Date: {_date}");
            Console.WriteLine();
            Console.WriteLine($"Customer information:");
            Console.WriteLine($"\t\t\tCustomer ID:  {_customer.CusID}");
            Console.WriteLine($"\t\t\tName:  {_customer.CusName}");
            Console.WriteLine($"\t\t\tAddess:  {_customer.CusAddress}");
            Console.WriteLine($"\t\t\tPhone Number:  {_customer.CusPhone}");
            Console.WriteLine();
            Console.WriteLine($"Invoice Details:");
            Console.WriteLine($"|{"ID",-7}|{"PRODUCT",-30}|{"UNIT COST",-10}|{"QUANTITY",-10}|{"PRICE",-10}|");
            foreach (var invoice in _invoiceDetailsList)
            {
                Console.WriteLine($"|{invoice.Product.Id,-7}|{invoice.Product.Name,-30}|{invoice.Product.Price,-10}|{invoice.Quantity,-10}|{invoice.Total,-10}|");
            }
            Console.WriteLine();
            Console.WriteLine($"\t\t\t\t\t\t\tTOTAL: {_total} VND");
        }
        public InvoiceDetails addProduct()
        {
            Console.WriteLine("\t Choose Product: (1 - Fan,\t\t2 - Air Conditioner)");
            int choose1 = MyIO.getInt(1, 2, "\t + Enter your choice: ", "\t Your choice must be 1 or 2! Please try again!");
            int choose2;
            switch (choose1)
            {
                case 1:
                    {
                        Console.WriteLine("\t\t Choose Fan: (1 - Stand Fan,\t\t2 - Steam Fan,\t\t3 - Electric Fan)");
                        choose2 = MyIO.getInt(1, 3, "\t\t + Enter your choice: ");
                        switch (choose2)
                        {
                            case 1:
                                {
                                    return new InvoiceDetails(new StandFans());
                                }
                            case 2:
                                {
                                    return new InvoiceDetails(new SteamFans());
                                }
                            case 3:
                                {
                                    return new InvoiceDetails(new ElectricFans());
                                }
                        }
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("\t\t Choose Air Conditioner: (1 - 1-Way Air Conditioner,\t\t2 - 2-Way Air Conditioner)");
                        choose2 = MyIO.getInt(1, 2, "\t\t + Enter your choice: ", "\t\t Your choice must be 1 or 2! Please try again!");
                        switch (choose2)
                        {
                            case 1:
                                {
                                    return new InvoiceDetails(new OneWayAC());
                                }
                            case 2:
                                {
                                    return new InvoiceDetails(new TwoWayAC());
                                }
                        }
                        break;
                    }
            }
            return null;
        }
        public void saveFile()
        {
            StreamWriter sw = File.AppendText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\invoices.txt");
            sw.WriteLine($"Invoice ID: {_id,-20} \t Date: {_date}");
            sw.WriteLine();
            sw.WriteLine($"Customer information:");
            sw.WriteLine($"\t\t\tCustomer ID:  {_customer.CusID}");
            sw.WriteLine($"\t\t\tName:  {_customer.CusName}");
            sw.WriteLine($"\t\t\tAddess:  {_customer.CusAddress}");
            sw.WriteLine($"\t\t\tPhone Number:  {_customer.CusPhone}");
            sw.WriteLine();
            sw.WriteLine($"Invoice Details:");
            sw.WriteLine($"|{"ID",-7}|{"PRODUCT",-30}|{"UNIT COST",-10}|{"QUANTITY",-10}|{"PRICE",-10}|");
            foreach (var invoice in _invoiceDetailsList)
            {
                sw.WriteLine($"|{invoice.Product.Id,-7}|{invoice.Product.Name,-30}|{invoice.Product.Price,-10}|{invoice.Quantity,-10}|{invoice.Total,-10}|");
            }
            sw.WriteLine();
            sw.WriteLine($"\t\t\t\t\t\t\tTOTAL: {_total} VND");
            sw.WriteLine("-----------------------------");
            sw.Close();
        }
    }
}
