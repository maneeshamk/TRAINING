using System;

class Program
{
    public static void Main(string[] args)
    {
        // 1. Char to Byte (Type Conversion)
        char ch = 'B';
        byte asciiValue = (byte)ch;

        Console.WriteLine("=== Type Conversion (char to byte) ===");
        Console.WriteLine("Character: " + ch);
        Console.WriteLine("ASCII (byte) value of '" + ch + "': " + asciiValue);
        Console.WriteLine();

        // 2. Min, Max, and Size of char
        Console.WriteLine("=== Char Type Info ===");
        Console.WriteLine("Minimum char value (Unicode code point): " + (int)char.MinValue);
        Console.WriteLine("Maximum char value (Unicode code point): " + (int)char.MaxValue);
        Console.WriteLine("Size of char (in bytes): " + sizeof(char));
        Console.WriteLine();

        // 3. Accepting two numbers from user
        Console.WriteLine("=== Sum of Two Numbers ===");
        Console.Write("Enter first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int sum = num1 + num2;
        Console.WriteLine("Sum of " + num1 + " and " + num2 + " is: " + sum);

        Console.ReadKey(); // Keeps the console window open
    }
}
