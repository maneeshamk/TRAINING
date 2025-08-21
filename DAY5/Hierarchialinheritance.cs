// using System;

// public class Person
// {
//     // Property
//     protected string Name { get; set; }

//     public virtual void Display()
//     {
//         Console.WriteLine("Displaying Name you entered: " + Name);
//     }

//     public void SetName(string name)
//     {
//         this.Name = name;
//     }
// }

// public class Student : Person
// {
//     public Student() { }

//     public Student(string name)
//     {
//         SetName(name);
//     }

//     public int RollNumber { get; set; }

//     public void Study()
//     {
//         Console.WriteLine(Name + " is studying.");
//     }

//     public static void Main()
//     {
//         Student stud = new Student();
//         stud.SetName("Niti");
//         stud.RollNumber = 2004;
//         stud.Display();
//         stud.Study();

//         // Call Teacher example here for demonstration
//         Console.WriteLine("\n--- Teacher Example ---");
//         Teacher t = new Teacher();
//         t.SetName("Preeti");
//         t.Subject = "Computer Science";
//         t.Teaches();
//         t.Display();
//     }
// }

// public class Teacher : Person
// {
//     public string Subject { get; set; }

//     public void Teaches()
//     {
//         Console.WriteLine(Name + " teaches " + Subject);
//     }
// }
