using ECommerce.DataAccessLayer.Infrastructure.Contracts;
using ECommerce.Domain.Entities;
using Ecommerce_Shahzeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce_Shahzeb.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _service;
        public CategoryController(ICategoryService service) { 
          _service = service;

        }
        public IActionResult CategoryList() {
            List<Category> list = _service.GetAll();
            var categoryModel = list.Select(c => new CategoryModel
            {
                Id = c.Id,
                CategoryName = c.CategoryName,
                Description = c.Description,
                Image=c. image,  
            }).ToList();
            return View(categoryModel);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category category) {
            if (category != null) 
            { 
             _service.Insert(category);                  
            }
            return RedirectToAction("CategoryList");
        
        }
        public IActionResult Edit(int Id) { 
        var category = _service.GetById(Id);
            var categoryModel = new CategoryModel
            {
                Id = category.Id,
                CategoryName=category.CategoryName,
                Description = category.Description,
                Image=category.image,

            };
            return View(categoryModel);
        }
        [HttpPost]
        public IActionResult Edit(Category category) {
            if (category != null)
            {
                _service.Update(category);
            }
            return RedirectToAction("CategoryList");
        }
    }

}
