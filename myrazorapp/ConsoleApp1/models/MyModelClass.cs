using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.models
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
