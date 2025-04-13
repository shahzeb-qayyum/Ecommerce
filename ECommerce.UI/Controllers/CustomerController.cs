using ECommerce.DataAccessLayer.Infrastructure.Contraccts;
using ECommerce.Domain.Entities;
using ECommerce.UI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.UI.Controllers
{
    public class CustomerController : Controller
    {
        private ICustomer _service; 
        public CustomerController(ICustomer service)
        {
            _service = service;
        }
        public IActionResult CustomerList()
        {
            List<Customer> list = _service.GetAll();

            // Map Customer to CustomerModel
            var customerModels = list.Select(c => new CustomerModel
            {
                Id = c.Id,
                FirstName = c.FirstName,
                LastName = c.LastName
            }).ToList();


            return View(customerModels);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Customer customer) 
        {
            if (customer != null)
            {
                _service.Insert(customer);
            }
            return RedirectToAction("CustomerList");
        }

    }
}
