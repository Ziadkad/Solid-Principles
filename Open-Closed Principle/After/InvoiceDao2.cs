

namespace Open_Closed_Principle.After
{
    internal class InvoiceDao2
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
