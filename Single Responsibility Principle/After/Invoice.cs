using Single_Responsibility_Principle.Before;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Single_Responsibility_Principle.After
{
    //In this improved version, we've divided the tasks of the Invoice class into three different classes: Invoice, InvoiceDao, and InvoicePrinter.
    //The Invoice class now only handles calculating the total amount.The tasks of printing and saving the invoice have been assigned to separate classes.This makes the code more organized, simpler to grasp, and reduces the chances of mistakes.
    internal class Invoice
    {
        public Product Product;
        public int Quantity { get; set; }
        public Invoice(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }
        public int calculateTotal()
        {
            return Product.Price * Quantity;
        }

    }
}
