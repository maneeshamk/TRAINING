using System;

class Program
{
    public static void Main(string[] args)
    {
        // Character declaration
        char ch = 'B'; // Character to be converted

        // Type Conversion: char to byte (ASCII value)
        byte asciiValue = (byte)ch;

        // Output the original character and its ASCII value
        Console.WriteLine("Character: " + ch);
        Console.WriteLine("ASCII (byte) value of '" + ch + "': " + asciiValue);

        // Show min and max possible values of char type
        Console.WriteLine("Minimum char value (Unicode): " + (int)char.MinValue);
        Console.WriteLine("Maximum char value (Unicode): " + (int)char.MaxValue);

        // Show the size of char in bytes
        Console.WriteLine("Size of char (in bytes): " + sizeof(char));

        Console.ReadKey(); // Pause the output window
    }
}

