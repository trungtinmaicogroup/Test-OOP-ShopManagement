using ShopManagement.trungtin.products;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.trungtin.invoices
{
    internal class InvoiceDetails
    {
        private Products _product;
        private int _quantity;
        private double _total;

        public InvoiceDetails()
        {

        }
        public InvoiceDetails(Products product, int quantity = 1)
        {
            Product = product;
            Quantity = quantity;
            Total = quantity * product.Price;
        }
        public Products Product
        {
            get => _product;
            set => _product = value;
        }
        public int Quantity
        {
            get => _quantity;
            set => _quantity = value;
        }
        public double Total
        {
            get => _total;
            set => _total = value;
        }
        public void input ()
        {
            _product = new Products();
        }
    }
}
