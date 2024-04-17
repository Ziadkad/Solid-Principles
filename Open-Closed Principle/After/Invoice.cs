

namespace Open_Closed_Principle.After

{

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
