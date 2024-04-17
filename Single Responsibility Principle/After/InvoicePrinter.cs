using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility_Principle.After
{
    internal class InvoicePrinter
    {
        public Invoice Invoice { get; set; }

        public InvoicePrinter(Invoice invoice)
        {
            Invoice = invoice;
        }
        public void printInvoice()
        {
            // printing implementation
        }
    }
}
