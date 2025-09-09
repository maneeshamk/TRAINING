// using System;

// namespace oops.poly
// {
//     class InfoPrinter
//     {
//         public int Pages;

//         // Default constructor
//         public InfoPrinter()
//         {
//             Console.WriteLine("Default Constructor Called");
//         }

//         // Parameterized constructor
//         public InfoPrinter(int pages)
//         {
//             this.Pages = pages + 1;
//             Console.WriteLine("Total Pages Printed: " + this.Pages);
//         }

//         // Method Overloading
//         public void Print(string name, int empId)
//         {
//             Console.WriteLine("Name: " + name + " | EmpId: " + empId);
//         }

//         public void Print(int empId, string name)
//         {
//             Console.WriteLine("EmpId: " + empId + " | Name: " + name);
//         }

//         static void Main()
//         {
//             InfoPrinter infPrinter = new InfoPrinter();            // Calls default constructor
//             infPrinter.Print("Niti", 1001);                         // Calls method with (string, int)
//             infPrinter.Print(1002, "Sakshi");                       // Calls method with (int, string)

//             InfoPrinter infPrinter1 = new InfoPrinter(23);         // Calls parameterized constructor
//             InfoPrinter infPrinter2 = new InfoPrinter(12);         // Calls parameterized constructor
//         }
//     }
// }
