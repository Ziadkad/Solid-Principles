using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility_Principle.After
{
    internal class InvoiceDao
    {
        public Invoice Invoice { get; set; }

        public InvoiceDao(Invoice invoice)
        {
            Invoice = invoice;
        }

        public void saveToDb() { }
    }
}
