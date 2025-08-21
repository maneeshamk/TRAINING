// using System;

// public class Person
// {
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

// public interface ICurricularActivities
// {
//     void Stream();
// }

// public interface INonCurricularActivities
// {
//     void Activities();
// }

// public class Student : Person, ICurricularActivities, INonCurricularActivities
// {
//     public int RollNumber { get; set; }

//     public void Study()
//     {
//         Console.WriteLine(Name + " is studying.");
//     }

//     public void Stream()
//     {
//         Console.WriteLine("Taken Science Stream");
//     }

//     public void Activities()
//     {
//         Console.WriteLine("Sports - Basketball");
//     }

//     static void Main()
//     {
//         Student s = new Student();

//         Console.WriteLine("Enter the name of student:");
//         string sname = Console.ReadLine();
//         s.SetName(sname);

//         s.RollNumber = 1001; // Example roll number
//         s.Study();
//         s.Display();
//         s.Stream();
//         s.Activities();
//     }
// }
