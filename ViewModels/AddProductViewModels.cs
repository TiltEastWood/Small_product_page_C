using Small_product_page_C_.Models;

namespace Small_product_page_C_.ViewModels
{
    public class AddProductViewModels
    {
        public string Sku { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public ProductType ProductType { get; set; }

        public int? Height { get; set; }
        public int? Width { get; set; }
        public int? Length { get; set; }
        public int? Weight { get; set; }
        public int? StorageMB { get; set; }
    }
}
   
