namespace CoreRazorApp.Models
{
    public class Employee1
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public int Department1Id { get; set; }

        public Department1 Department1 { get; set; }
    }
}
