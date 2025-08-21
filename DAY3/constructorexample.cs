// using System;

// class Employee
// {
//     public string Name { get; set; }
//     public int Age { get; set; }

//     public static int Count = 0;

//     // Default constructor
//     public Employee()
//     {
//         Count++;
//         Console.WriteLine("The value of count is : " + Count);
//         Name = "niti";
//         Age = 34;
//     }

//     // Constructor with name and age
//     public Employee(string name, int age) : this() // Call default constructor to increment count
//     {
//         Name = name;
//         Age = age;
//     }

//     // Constructor with only name
//     public Employee(string name) : this() // Call default constructor to increment count
//     {
//         Name = name;
//         Age = 0; // Default value
//     }

//     public void Display()
//     {
//         Console.WriteLine("Name : " + Name + " Age : " + Age);
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Employee e1 = new Employee(); // Default
//         Employee e2 = new Employee("Preeti", 28); // Using parameterized constructor
//         Employee e3 = new Employee("Rahul"); // Using name-only constructor

//         e1.Display();
//         e2.Display();
//         e3.Display();
//     }
// }

