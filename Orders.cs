namespace ordersapi.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ProductDetail> ProductDetails { get; set; }

        public Order()
        {
            ProductDetails = new List<ProductDetail>();
        }
    }

    public class ProductDetail
    {
        public string Product { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}