using Open_Closed_Principle.After;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle.Before
{
    internal class InvoiceDao2 : IInvoiceDao
    {
        public Invoice Invoice { get; set; }

        public InvoiceDao2(Invoice invoice)
        {
            Invoice = invoice;
        }

        public void SaveToDb() {
            //saveToDb to database 2
        }
    }
}
