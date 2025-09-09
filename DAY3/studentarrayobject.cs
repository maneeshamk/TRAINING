// using System;

// class Student
// {
//     public string Name { get; set; }
//     public int Age { get; set; }
//     public int[] SubjectMarks { get; set; }
// }

// class StudentArray
// {
//     static void Main()
//     {
//         Console.Write("Enter number of students: ");
//         int studentCount = Convert.ToInt32(Console.ReadLine());

//         Student[] students = new Student[studentCount]; // Array of student class 

//         for (int i = 0; i < studentCount; i++)
//         {
//             students[i] = new Student(); // Create a new Student object

//             Console.WriteLine($"\nEnter details for Student {i + 1}:");

//             Console.Write("Enter name of student: ");
//             students[i].Name = Console.ReadLine();

//             Console.Write("Enter Age of student: ");
//             students[i].Age = Convert.ToInt32(Console.ReadLine());

//             Console.Write("How many subjects do you want to store marks for? ");
//             int subjectCount = Convert.ToInt32(Console.ReadLine());

//             students[i].SubjectMarks = new int[subjectCount];

//             for (int j = 0; j < subjectCount; j++)
//             {
//                 Console.Write($"Enter marks for subject {j + 1}: ");
//                 students[i].SubjectMarks[j] = Convert.ToInt32(Console.ReadLine());
//             }
//         }

//         Console.WriteLine("\nStudent details are given below:");

//         foreach (Student s in students)
//         {
//             Console.WriteLine($"\nName: {s.Name}");
//             Console.WriteLine("Age: " + s.Age);

//             Console.WriteLine("Subject Marks:");
//             foreach (int marks in s.SubjectMarks)
//             {
//                 Console.WriteLine(marks);
//             }
//         }
//     }
// }
