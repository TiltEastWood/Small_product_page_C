namespace Small_product_page_C_.Models
{
    public abstract class Product
    {
        public int Sku { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public ProductType ProductType { get; set; }
    }
}
