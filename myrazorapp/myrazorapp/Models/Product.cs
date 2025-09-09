namespace myrazorapp.Models
{
    public class Product
    {
        public int Id { get; set; }   // Primary key
        public string Name { get; set; } = string.Empty;

        // Foreign key
       
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}
