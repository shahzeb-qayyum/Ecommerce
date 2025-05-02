using System.ComponentModel.DataAnnotations;
using ECommerce.DataAccessLayer.Infrastructure.Contracts;
using ECommerce.Domain.Entities;
using Ecommerce_Shahzeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce_Shahzeb.Controllers
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
            var customerModels = list.Select(c => new CustomerModel
            {
                Id = c.Id,
                FirstName=c.FirstName,
                LastName=c.LastName,
                Email = c.Email,
                Phone= c.Phone,

            }).ToList();
            return View(customerModels);
         }
        public IActionResult Create() {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Customer customer) {
            if (customer != null) { 
                  _service.Insert(customer);
               
            } 
            return RedirectToAction("CustomerList");
           }
        public IActionResult Edit(int Id) {
            var customer = _service.GetById(Id);
            var customerModel = new CustomerModel
            {
                Id= customer.Id,
                FirstName= customer.FirstName,
                LastName= customer.LastName,
                Email = customer.Email,
                Phone= customer.Phone,
            };
            return View(customerModel); 

        }
        [HttpPost]
        public IActionResult Edit(Customer customer) {
            if (customer != null) { 
                _service.Update(customer);            
            }
            return RedirectToAction("CustomerList");
        }

    }
}
