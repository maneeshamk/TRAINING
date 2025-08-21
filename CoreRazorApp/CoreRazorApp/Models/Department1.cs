namespace CoreRazorApp.Models
{
    public class Department1
    {
        public int Id { get; set; }
        public string DepartmentName { get; set; }

        public ICollection<Employee1> Employees { get; set; }
    }
}
