// using System;
// class DelegateExample
// {
//     // Delegate to calculate invoice
//     public delegate int Admin(int tuitionFees, int transportFees);
//     // Delegate to print invoice
//     public delegate void Print(int result);
//     // Static method to calculate
//     public static int CalculateInvoice(int tuitionFees, int transportFees)
//     {
//         return tuitionFees + transportFees;
//     }
//     // Static method to print
//     public static void PrintInvoice(int result)
//     {
//         Console.WriteLine("Total Invoice Amount: ₹" + result);
//     }
//     static void Main()
//     {
//         Admin a = new Admin(CalculateInvoice);
//         int total = a(200, 500);
//         Print p = new Print(PrintInvoice);
//         p(total);
//     }
// }