using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.DataAccessLayer.Infrastructure.Services;
using ECommerce.Domain.Entities;

namespace ECommerce.DataAccessLayer.Infrastructure.Contracts
{
   public interface IEmployee
    {
        Employee Insert(Employee employee);

        List<Employee> GetAll();

        Employee Update(Employee employee);

        bool Delete(int Id);

        Employee GetById(int Id);
    }
}
