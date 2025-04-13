using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.DataAccessLayer.Infrastructure.Contraccts;
using ECommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.DataAccessLayer.Infrastructure.Services
{
    public class CustomerService : ICustomer
    {
        private ECommerceDbContext db;
        public CustomerService(ECommerceDbContext context) {
            db = context;
        }

        public List<Customer> GetAll()
        {
           return db.Customers.ToList();
        }

        public Customer Insert(Customer customer)
        {
            db.Add(customer);
            db.SaveChanges();
            return customer;
        }
    }
}
