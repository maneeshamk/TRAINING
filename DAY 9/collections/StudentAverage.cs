// using System;
// using System.Collections.Generic;

// public class Student
// {
//     public int ID { get; set; }
//     public string Name { get; set; }
//     public Dictionary<string, int> SubjectMarks { get; set; }

//     public Student(int id, string name, Dictionary<string, int> subjectMarks)
//     {
//         ID = id;
//         Name = name;
//         SubjectMarks = subjectMarks;
//     }

//     public double GetAverage()
//     {
//         int total = 0;
//         foreach (var marks in SubjectMarks.Values)
//         {
//             total += marks;
//         }
//         return (double)total / SubjectMarks.Count;
//     }

//     public void Display()
//     {
//         Console.WriteLine("Student id: " + ID);
//         Console.WriteLine("Student name: " + Name);
//         Console.WriteLine("Student Marks:");
//         foreach (var subject in SubjectMarks)
//         {
//             Console.WriteLine(subject.Key + ": " + subject.Value);
//         }
//         Console.WriteLine("Average Marks: " + GetAverage());
//         Console.WriteLine(); // Blank line for readability
//     }

//     // Main method added here
//     public static void Main()
//     {
//         // Create sample subject marks
//         Dictionary<string, int> marks1 = new Dictionary<string, int>()
//         {
//             {"Math", 95},
//             {"Science", 88},
//             {"English", 92}
//         };

//         Dictionary<string, int> marks2 = new Dictionary<string, int>()
//         {
//             {"Math", 78},
//             {"Science", 84},
//             {"English", 80}
//         };

//         // Create student objects
//         Student student1 = new Student(1, "Niti", marks1);
//         Student student2 = new Student(2, "Preeti", marks2);

//         // Display details
//         student1.Display();
//         student2.Display();
//     }
// }