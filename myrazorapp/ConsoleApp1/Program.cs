using ConsoleApp1.models;
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            CRUD c = new CRUD();

            // === Add Category ===
            Console.WriteLine("=== Add a New Category ===");

            Console.Write("Enter item Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Description: ");
            string description = Console.ReadLine();

            Console.Write("Enter Category Type (Fashion, Vehicle, Stationery): ");
            string categoryType = Console.ReadLine();

            Category newCategory = new Category
            {
                Name = name,
                Description = description,
                CategoryType = (CategoryTypeEnum)Enum.Parse(typeof(CategoryTypeEnum), categoryType, true)
            };

            string result = c.AddCategory(newCategory);
            Console.WriteLine(result);

            // === Update Category ===
            Console.WriteLine("\n=== Update a Category ===");
            Console.Write("Enter Category ID to update: ");
            int updateId = int.Parse(Console.ReadLine());

            Console.Write("Enter new Name: ");
            string newName = Console.ReadLine();

            Console.Write("Enter new Description: ");
            string newDescription = Console.ReadLine();

            Console.Write("Enter new Category Type (Fashion, Vehicle, Stationery): ");
            string newCategoryType = Console.ReadLine();

            Category updatedCategory = new Category
            {
                Id = updateId,
                Name = newName,
                Description = newDescription,
                CategoryType = (CategoryTypeEnum)Enum.Parse(typeof(CategoryTypeEnum), newCategoryType, true)
            };

            string updateResult = c.UpdateCategory(updatedCategory);
            Console.WriteLine(updateResult);

            // === Delete Category ===
            Console.WriteLine("\n=== Delete a Category ===");
            Console.Write("Enter Category ID to delete: ");
            int idToDelete = int.Parse(Console.ReadLine());

            string deleteResult = c.DeleteCategory(idToDelete);
            Console.WriteLine(deleteResult);

            // === Show Updated Categories List ===
            Console.WriteLine("\n=== Updated Categories List ===");
            List<Category> categoryList = c.GetCategories();

            foreach (Category cat in categoryList)
            {
                Console.WriteLine(
                    $"ID: {cat.Id} | Name: {cat.Name} | Description: {cat.Description} | CategoryType: {cat.CategoryType}"
                );
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
