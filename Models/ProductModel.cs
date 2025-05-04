namespace Ecommerce_Shahzeb.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string? ProductName { get; set; }
        public string? ProductDiscription { get; set; }
        public int UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public int ReOrderLevel { get; set; }
        public bool Discontinued { get; set; }
        public int QuanitityPerUnit { get; set; }
        public int CategoryId { get; set; }
    }
}
