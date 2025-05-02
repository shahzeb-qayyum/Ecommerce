using System.ComponentModel.DataAnnotations;
using ECommerce.DataAccessLayer.Infrastructure.Contracts;
using ECommerce.Domain.Entities;
using Ecommerce_Shahzeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;

namespace Ecommerce_Shahzeb.Controllers
{
    public class EmployeeController : Controller
    {
        private IEmployee _service;
        public EmployeeController(IEmployee service)
        {
            _service = service;
        }
        public IActionResult EmployeeList()
        {
            List<Employee> list = _service.GetAll();
            var employeeModels = list.Select(c => new EmployeeModel
            {
                Id = c.Id,
                FirstName = c.FirstName,
                LastName = c.LastName,
                Email = c.Email,
                Phone = c.Phone,

            }).ToList();
            return View(employeeModels);

        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            if (employee != null)
            {
                _service.Insert(employee);
            }
            return RedirectToAction("EmployeeList");
        }
        public IActionResult Edit(int Id)
        {
            var employee = _service.GetById(Id);
            var employeeModel = new EmployeeModel
            {
                Id=employee.Id,
                FirstName=employee.FirstName,
                LastName=employee.LastName,
                Email=employee.Email,
                Phone=employee.Phone,   
            };
            return View(employeeModel);
        }
        [HttpPost]
        public IActionResult Edit(Employee employee) { 
          if (employee != null)
            {
                _service.Update(employee);
            }
            return RedirectToAction("EmployeeList");
        }
    }
}
