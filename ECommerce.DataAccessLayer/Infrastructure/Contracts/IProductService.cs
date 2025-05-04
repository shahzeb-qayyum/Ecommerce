using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Domain.Entities;

namespace ECommerce.DataAccessLayer.Infrastructure.Contracts
{
    public interface IProductService
    {
        Product Insert(Product customer);
        Product Update(Product customer);
        Product GetById(int Id);
        bool Delete(int Id);
        List<Product> GetAll();
    }
}
