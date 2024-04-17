

namespace Open_Closed_Principle.After
{
    internal class InvoiceDao : IInvoiceDao
    {
        public Invoice Invoice { get; set; }

        public InvoiceDao(Invoice invoice)
        {
            Invoice = invoice;
        }

        public void SaveToDb() {
            //saveToDb to database 1
        }
    }
}
