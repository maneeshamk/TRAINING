using System.ComponentModel.DataAnnotations;

namespace myMVCexample.Models
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        // Property that uses the enum type
        [Display(Name = "Category Type")]
        public CategoryTypeEnum CategoryType { get; set; }
    }

    //Enum declared outside the class
    public enum CategoryTypeEnum
    {
        [Display(Name = "Fashion")] Fashion = 1,
        [Display(Name = "Vehicle")] Vehicle = 2,
        [Display(Name = "Stationery")] Stationery = 3
    }
}



