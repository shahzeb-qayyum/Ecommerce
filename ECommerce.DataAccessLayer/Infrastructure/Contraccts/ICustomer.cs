using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Domain.Entities;

namespace ECommerce.DataAccessLayer.Infrastructure.Contraccts
{
    public interface ICustomer
    {
       Customer Insert(Customer customer);
        List<Customer> GetAll();
    }
}
