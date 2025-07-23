// using System;
// class StringPrograms
// {
//     static void Main()
//     {

//         string text = "CSharp Language invented in 2002";

//         int length = text.Length; //15
//         Console.WriteLine("The Length of a string : " + length);
//         string subString = text.Substring(7, 8);
//         Console.WriteLine("The text from a string : " + subString);
//         Console.WriteLine(text.IndexOf("harp"));
//         Console.WriteLine(text.ToUpper());
//         string newString = text.Replace("CSharp", "Java");
//         Console.WriteLine(newString);

//         String replaced = text.Replace(" ", "");
//         Console.WriteLine("Without space : " + replaced.Length);

//         int pos = text.IndexOf("Language");
//         string newText = text.Substring(pos, 8);
//         Console.WriteLine("New Text Value " + newText.ToUpper());

//         string data = "CSharp,Language";
//         String[] lang = data.Split(',');
//         foreach (string valuess in lang)
//         {
//             Console.WriteLine(valuess);

//             // Task 1: Count blank spaces
//             string text1 = "This is a simple sentence with spaces.";
//             int spaceCount = 0;
//             foreach (char ch in text1)
//             {
//                 if (ch == ' ')
//                     spaceCount++;
//             }
//             Console.WriteLine("Blank spaces count: " + spaceCount);

//             Console.WriteLine();

//             // Task 2: Count special characters
//             string text2 = "Hello@World! Today is #great.";
//             int specialCount = 0;
//             foreach (char ch in text2)
//             {
//                 if (!char.IsLetterOrDigit(ch) && ch != ' ')
//                     specialCount++;
//             }
//             Console.WriteLine("Special characters count: " + specialCount);

//             Console.WriteLine();

//             // Task 3: Count words
//             string text3 = "Learning CSharp is fun and useful";
//             string[] words = text3.Split(' ', StringSplitOptions.RemoveEmptyEntries);
//             Console.WriteLine("Words count: " + words.Length);
//              int vCount = 0;
//         int cCount = 0;
//         int splCharCount = 0;
//         int numCount = 0;
//         int spaceCount = 0;

//         string givenData = "Hello! Team, submit the Project 23-07-2005.";
//         char[] vowels = ['a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'];
//         foreach (char c in givenData)
//         {
//             if (vowels.Contains(c))
//             {
//                 vCount++;
//             }
//             else
//             {
//                 if (!char.IsLetterOrDigit(c) && !char.IsWhiteSpace(c))
//                 {
//                     splCharCount++;
//                 }
//                 else if (char.IsLetter(c))
//                 {
//                     cCount++;
//                 }
//                 else if (char.IsDigit(c))
//                 {
//                     numCount++;
//                 }
//                 else if (char.IsWhiteSpace(c))
//                 {
//                     spaceCount++;
//                 }
//             }
//         }
//         Console.WriteLine("Vowels : " + vCount);
//         Console.WriteLine("Consonants : " + cCount);
//         Console.WriteLine("special : " + splCharCount);
//         Console.WriteLine("Numeric : " + numCount);
//         Console.WriteLine("Spaces : " + spaceCount);
//         //--------------------------------------------------------
//     }
// }

//         }
    


    



