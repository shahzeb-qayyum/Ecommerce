namespace Ecommerce_Shahzeb.Models
{
    public class CategoryModel
    {
         
        public int Id { get; set; }
        public string CategoryName { get; set; } = string.Empty;
        public string? Description { get; set; }
        public byte[]? Image { get; set; }

    }
}
