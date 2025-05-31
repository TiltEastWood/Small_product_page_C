using Microsoft.AspNetCore.Mvc;
using Small_product_page_C_.Models;
using Small_product_page_C_.ViewModels;
using Small_product_page_C_.Data;
using System.Linq;

namespace Small_product_page_C_.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;
        public ProductController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Add()
        {
            return View();
        }
        public IActionResult Product_page()
        {
            var model = new ViewProducts
            {
                Products = _context.Products.ToList()
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult Add(AddProductViewModels model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            Product product = null;

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
                        Length = model.Length ?? 0
                    };
                    break;

                default:
                    product = null;
                    break;
            }
            if (product != null) 
            {
                _context.Products.Add(product);
                _context.SaveChanges();
            }

            return RedirectToAction("Product_page");
        }
    }
}
