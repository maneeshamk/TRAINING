using System;

class Student
{
    public void Display()
    {
        Console.WriteLine("Hello, I am a student!");
    }
}

class Program
{
    static void Main()
    {
        // Creating an object 's' of class Student
        Student s = new Student();
        
        // Calling the Display() method using the object
        s.Display();
    }
}
