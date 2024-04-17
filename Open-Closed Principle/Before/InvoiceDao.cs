
namespace Open_Closed_Principle.Before
{
    //The InvoiceDao class has a single responsibility of saving the invoice to the database 1 . But, suppose there's a new requirement to save the invoice to the database 2. One way to implement this requirement would be to modify the existing InvoiceDao class by adding a saveToDb2() method. But this violates the Open-Closed Principle because it modifies the existing code that has already been tested and is live in production.
    internal class InvoiceDao
    {
        public Invoice Invoice { get; set; }

        public InvoiceDao(Invoice invoice)
        {
            Invoice = invoice;
        }

        public void saveToDb() {
            //saveToDb to database 1
        }
    }
}
