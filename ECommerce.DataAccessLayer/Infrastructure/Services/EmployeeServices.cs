using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.DataAccessLayer.Infrastructure.Contracts;
using ECommerce.Domain.Entities;

namespace ECommerce.DataAccessLayer.Infrastructure.Services
{
   public class EmployeeServices : IEmployee
    {
        private ECommerceDbContext db;

        public EmployeeServices(ECommerceDbContext context)
        {
            this.db = context;
        }
        public bool Delete(int Id)
        {
            var EmployeeToDelete = GetById(Id);
            db.Employee.Remove(EmployeeToDelete);
            db.SaveChanges();
            return true;
        }
        public List<Employee> GetAll() { 
          var Employee =db.Employee.ToList();
            return Employee;
        }
        public Employee GetById(int Id) { 
          var Employee = db.Employee.Where(cust => cust.Id ==Id).FirstOrDefault() ;
            return Employee;
        
        }
        public Employee Insert(Employee employee) { 
           db.Add(employee);
            db.SaveChanges();
            return employee;    
        }
        public Employee Update(Employee employee) {
          var EmployeeToUpdate = GetById(employee.Id);
            EmployeeToUpdate.FirstName = employee.FirstName;
            EmployeeToUpdate.LastName = employee.LastName;
            EmployeeToUpdate.Email = employee.Email;
            EmployeeToUpdate.Phone = employee.Phone;
            db.Employee.Update(EmployeeToUpdate);
            db.SaveChanges();
            return employee;
        }
        }
}
