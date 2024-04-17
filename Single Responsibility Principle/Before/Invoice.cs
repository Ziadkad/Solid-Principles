using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility_Principle.Before
{



    //The Invoice class does too many things at once. It calculates the total amount, prints the invoice, and saves it to the database. If we want to change how the total is calculated, or how the invoice is printed or saved, we have to change the whole class.
    internal class Invoice
    {
        public Product Product;
        public int Quantity { get; set; }
        public Invoice(Product product,int quantity) {
            Product = product;
            Quantity = quantity;
        }
        public int calculateTotal()
        {
            return Product.Price * Quantity;
        }
        public void printInvoice() { }
        public void saveToDb() { }
    }
}
