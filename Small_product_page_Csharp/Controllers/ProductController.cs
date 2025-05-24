using Microsoft.AspNetCore.Mvc;
using Small_product_page_C_.Models;
using Small_product_page_C_.ViewModels;

namespace Small_product_page_C_.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(AddProductViewModels model)
        {
            if (ModelState.IsValid)
            {
                return View(model);
            }

            Product product;

            switch (model.ProductType)
            {
                case ProductType.Book:
                    product = new Book
                    {
                        Sku = model.Sku,
                        Name = model.Name,
                        Price = model.Price,
                        ProductType = model.ProductType,
                        Weight = model.Weight ?? 0,
                    };
                    break;

                case ProductType.CD:
                    product = new CD
                    {
                        Sku = model.Sku,
                        Name = model.Name,
                        Price = model.Price,
                        ProductType = model.ProductType,
                        StorageMB = model.StorageMB ?? 0
                    };
                    break;
                
                case ProductType.Furniture: 
                    product = new Furniture
                    {
                        Sku = model.Sku,
                        Name = model.Name,
                        Price = model.Price,
                        ProductType = model.ProductType,
                        Height = model.Height ?? 0,
                        Width = model.Width ?? 0,
                        Lenght = model.Lenght ?? 0
                    };
                    break;

                default:
                    product = null;
                    break;
            }
            if (product != null) 
            {
                //Save to DB
            }

            return RedirectToAction("Index");
        }
    }
}
