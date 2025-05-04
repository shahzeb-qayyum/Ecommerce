using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductDiscription { get; set; }
        public int UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public int ReOrderLevel { get; set; }
        public bool Discontinued { get; set; }
        public int QuanitityPerUnit { get; set; }
        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
