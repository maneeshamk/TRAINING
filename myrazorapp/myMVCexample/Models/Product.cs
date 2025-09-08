using System.ComponentModel.DataAnnotations;
using Aspose.Cells.Charts;

namespace myMVCexample.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public int CategoryId { get; set; }   // FK
        public Category Category { get; set; } // Navigation property
        public object CategoryType { get; internal set; }
    }
}


