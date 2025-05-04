using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.DataAccessLayer.Infrastructure.Contracts;
using ECommerce.Domain.Entities;

namespace ECommerce.DataAccessLayer.Infrastructure.Services
{
    public class CustomerServices : ICustomer
    {
        private ECommerceDbContext db;
        public CustomerServices(ECommerceDbContext context)
        {
            db = context;
        }

        public bool Delete (int Id)
        {
            var customerToDelete = GetById(Id);
            db.Customer.Remove(customerToDelete);
            db.SaveChanges();
            return true;
        }

     public Customer GetById(int Id)
        {
            var customer = db.Customer.Where(cust => cust.Id == Id).FirstOrDefault();
            return customer;
        }
        public List<Customer> GetAll() { 
          var customers=db.Customer.ToList();
            return customers;
        }
        public Customer Insert(Customer customer) {
            db.Add(customer);
            db.SaveChanges();
            return customer;
                }

        public Customer Update(Customer customer) { 
           var CustomerToUpdate = GetById(customer.Id);
            CustomerToUpdate.FirstName = customer.FirstName;
            CustomerToUpdate.LastName = customer.LastName;
            CustomerToUpdate.Email = customer.Email;
            CustomerToUpdate.Phone = customer.Phone;
            db.SaveChanges();
            return CustomerToUpdate;
        }
    }
}
