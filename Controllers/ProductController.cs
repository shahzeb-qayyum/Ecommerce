using ECommerce.DataAccessLayer.Infrastructure.Contracts;
using Ecommerce_Shahzeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce_Shahzeb.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productservice)
        {
           _productService = productservice;            
        }
        public IActionResult ProductList()
        {
            var list = _productService.GetAll();
            IEnumerable<ProductModel> productList = list.Select(p => new ProductModel 
            {
                Id = p.Id,
                UnitPrice = p.UnitPrice,
                Discontinued = p.Discontinued,
                ProductName = p.ProductName,
                ProductDiscription = p.ProductDiscription,
                UnitsInStock = p.UnitsInStock,
                QuanitityPerUnit = p.QuanitityPerUnit,
                CategoryId = p.CategoryId,
            });

            return View(productList);
        }

        public IActionResult ShowAddProductPage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ProductModel product)
        {
        }
    }
}
