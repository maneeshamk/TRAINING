public class Program
{
    public static void Main()
    {
        StudentManager manager = new StudentManager();

        while (true)
        {
            Console.WriteLine("\n--- Student Manager ---");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Display All Students");
            Console.WriteLine("3. Search by Name");
            Console.WriteLine("4. Sort by Name");
            Console.WriteLine("5. Sort by Marks");
            Console.WriteLine("6. Exit");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter ID: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter Marks: ");
                    double marks = Convert.ToDouble(Console.ReadLine());
                    manager.AddStudent(new Student(id, name, marks));
                    break;

                case "2":
                    manager.DisplayAll();
                    break;

                case "3":
                    Console.Write("Enter name to search: ");
                    string searchName = Console.ReadLine();
                    manager.SearchStudentByName(searchName);
                    break;

                case "4":
                    manager.SortByName();
                    break;

                case "5":
                    manager.SortByMarks();
                    break;

                case "6":
                    return;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}