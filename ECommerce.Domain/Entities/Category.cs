using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Domain.Entities
{
   public class Category
    {
        public int Id { get; set; } 
        public string CategoryName { get; set; } = string.Empty;
        public string? Description { get; set; }
        public byte[]? image { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
