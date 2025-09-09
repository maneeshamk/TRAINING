// using System;

// public class Person
// {
//     // properties 
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

// // Single Inheritance
// public class Student : Person
// {
//     public Student() { } // parameterless constructor for demo

//     public int RollNumber { get; set; }

//     public void Study()
//     {
//         Console.WriteLine(Name + " is studying.");
//     }

//     static void Main()
//     {
//         Student stud = new Student();
//         stud.setName("Niti");
//         stud.RollNumber = 2004;

//         stud.Display();  // From base class
//         stud.Study();    // From derived class
//     }
// }
