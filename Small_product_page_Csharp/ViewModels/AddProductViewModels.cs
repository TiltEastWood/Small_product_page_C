using Small_product_page_C_.Models;

namespace Small_product_page_C_.ViewModels
{
    public class AddProductViewModels
    {
        public int Sku {  get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public ProductType ProductType { get; set; }

        public int? Height { get; set; }
        public int? Width { get; set; }
        public int? Lenght { get; set; }
        public int? Weight { get; set; }
        public int? StorageMB { get; set; }
    }
}
