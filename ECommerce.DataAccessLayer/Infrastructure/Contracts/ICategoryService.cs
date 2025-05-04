using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Domain.Entities;

namespace ECommerce.DataAccessLayer.Infrastructure.Contracts
{
    public interface ICategoryService
    {
        Category Insert(Category customer);
        Category Update(Category customer);
        Category GetById(int Id);
        bool Delete(int Id);
        List<Category> GetAll();


    }
}
