using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle.After
{   
    // A better solution would be to create an InvoiceDao interface and implement it separately for both databases
    //This way, if there's a new requirement to save the invoice to another data store, you can implement a new InvoiceDao implementation without modifying the existing code. Now the InvoiceDao interface is open for extension and closed for modification, which follows the OCP.
    internal interface IInvoiceDao
    {
        public void SaveToDb();
    }
}
