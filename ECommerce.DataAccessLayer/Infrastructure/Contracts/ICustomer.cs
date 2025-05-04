using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Domain.Entities;

namespace ECommerce.DataAccessLayer.Infrastructure.Contracts
{
    public interface ICustomer
    {
        Customer Insert(Customer customer );

        List<Customer> GetAll();

        Customer Update(Customer customer);

        bool Delete(int Id);

        Customer GetById(int Id);
        
    }
}
