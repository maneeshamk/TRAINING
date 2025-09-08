using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using ConsoleApp1.models;

namespace ConsoleApp1
{
    public class CRUD
    {
        // Connection string from App.config
        SqlConnection con = new SqlConnection(
            ConfigurationManager.ConnectionStrings["MyConnection"].ToString()
        );

        // Get all Categories
        public List<Category> GetCategories()
        {
            List<Category> categoryList = new List<Category>();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Categories", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                Category c = new Category()
                {
                    Id = int.Parse(row["Id"].ToString()),
                    Name = row["Name"].ToString(),
                    Description = row["Description"].ToString(),
                    CategoryType = (CategoryTypeEnum)Enum.Parse(
                        typeof(CategoryTypeEnum),
                        row["CategoryType"].ToString()
                    )
                };
                categoryList.Add(c);
            }

            return categoryList;
        }

        // Insert Category
        public string AddCategory(Category category)
        {
            string query =
                "INSERT INTO Categories (Name, Description, CategoryType) VALUES (@Name, @Description, @CategoryType)";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Name", category.Name);
                    cmd.Parameters.AddWithValue("@Description", category.Description);
                    cmd.Parameters.AddWithValue("@CategoryType", (int)category.CategoryType); // store enum as int

                    con.Open();
                    cmd.ExecuteNonQuery();
                    return "✅ Category inserted successfully!";
                }
            }
            catch (Exception ex)
            {
                return "❌ Category insert failed with error: " + ex.Message;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        // Update Category
        public string UpdateCategory(Category category)
        {
            string query =
                "UPDATE Categories SET Name = @Name, Description = @Description, CategoryType = @CategoryType WHERE Id = @Id";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Id", category.Id);
                    cmd.Parameters.AddWithValue("@Name", category.Name);
                    cmd.Parameters.AddWithValue("@Description", category.Description);
                    cmd.Parameters.AddWithValue("@CategoryType", (int)category.CategoryType);

                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                        return "✅ Category updated successfully!";
                    else
                        return "⚠️ No category found with the given ID.";
                }
            }
            catch (Exception ex)
            {
                return "❌ Category update failed with error: " + ex.Message;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        // Delete Category
        public string DeleteCategory(int categoryId)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Categories WHERE Id = @Id", con);
                cmd.Parameters.AddWithValue("@Id", categoryId);

                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                    return "✅ Category deleted successfully!";
                else
                    return "⚠️ No category found with the given ID.";
            }
            catch (Exception ex)
            {
                return "❌ Category delete failed with error: " + ex.Message;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }
    }
}
