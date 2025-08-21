// using System;

// public class Father
// {
//     public void FatherDetails()
//     {
//         Console.WriteLine("Father Details:");
//     }
// }

// public class Person : Father
// {
//     protected string Name { get; set; }

//     public virtual void Display()
//     {
//         Console.WriteLine("Displaying Name you entered: " + Name);
//     }

//     public void setName(string name)
//     {
//         this.Name = name;
//     }
// }

// public class Student : Person
// {
//     public int RollNumber { get; set; }

//     public Student() { } // Parameterless constructor if needed

//     public Student(string name)
//     {
//         Name = name;
//     }

//     public void Study()
//     {
//         Console.WriteLine(Name + " is studying.");
//     }
// }

// public class MainProgram
// {
//     public static void Main()
//     {
//         Student stud = new Student("Niti");
//         stud.RollNumber = 2004;

//         stud.FatherDetails();  // From Father class
//         stud.Display();        // From Person class
//         stud.Study();          // From Student class
//     }
// }
