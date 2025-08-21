// using System;

// class Voter
// {
//     private int age = 0;

//     public void SetAge(int age)
//     {
//         // 'this' keyword is used to distinguish between local variable and instance variable
//         this.age = age;

//         if (this.age < 18)
//         {
//             Console.WriteLine("Age should be greater than 18");
//         }
//     }

//     // ✅ Change this to public so it can be accessed from Main
//     public int GetAge()
//     {
//         return age;
//     }
// }

// class MainProgram
// {
//     static void Main()
//     {
//         Voter v = new Voter();

//         v.SetAge(12); // This will print the warning message
//         Console.WriteLine("Age set is: " + v.GetAge()); // Now accessible
//     }
// }
