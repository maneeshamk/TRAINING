// using System;
// using System.Collections.Generic;

// public class CollectionExamples
// {
//     public static void Main()
//     {
//         // List
//         List<string> students = new List<string>();
//         students.Add("Niti");
//         students.Add("Preeti");
//         // students.Add(34); // Not allowed: List<string> can't hold an int

//         Console.WriteLine("\nList of Students:");
//         foreach (string student in students)
//         {
//             Console.WriteLine(student);
//         }

//         // Dictionary
//         Dictionary<int, string> data = new Dictionary<int, string>();
//         data.Add(101, "Niti");
//         data.Add(102, "Preeti");

//         Console.WriteLine("\nDictionary Data:");
//         Console.WriteLine("Value for key 101: " + data[101]);

//         foreach (KeyValuePair<int, string> kv in data)
//         {
//             Console.WriteLine(kv.Key + " " + kv.Value);
//         }

//         // HashSet
//         HashSet<string> employees = new HashSet<string>();
//         employees.Add("Avc");
//         employees.Add("xyz");
//         employees.Add("Avc"); // Duplicate, will be ignored

//         Console.WriteLine("\nHashSet of Employees:");
//         foreach (string e in employees)
//         {
//             Console.WriteLine(e);
//         }

//         // Stack
//         Stack<string> todotask = new Stack<string>();
//         todotask.Push("Learn C#");
//         todotask.Push("Revise the concepts");
//         todotask.Push("Clear your exam");

//         Console.WriteLine("\nStack - ToDo Tasks:");
//         foreach (string task in todotask)
//         {
//             Console.WriteLine(task);
//         }

//         while (todotask.Count > 0)
//         {
//             todotask.Pop();
//             Console.WriteLine("One task is completed.");
//         }

//         // Queue
//         Queue<string> tickets = new Queue<string>();
//         tickets.Enqueue("Learn C#");
//         tickets.Enqueue("Revise the concepts");
//         tickets.Enqueue("Clear your exam");

//         Console.WriteLine("\nQueue - Tickets:");
//         foreach (string task in tickets)
//         {
//             Console.WriteLine(task);
//         }
//     }
// }
