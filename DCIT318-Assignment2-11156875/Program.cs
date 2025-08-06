using System;
using DCIT318_Assignment2_11156875;

class Program
{
    static void Main()
    {
        Console.WriteLine("Choose an application:");
        Console.WriteLine("1. Inheritance and Method Overriding");
        Console.WriteLine("2. Abstract Classes and Methods");
        Console.WriteLine("3. Interfaces");
        Console.Write("Enter your choice: ");

        string? choice = Console.ReadLine();

        if (choice == null)
        {
            Console.WriteLine("No input received. Exiting...");
            return;
        }
    }
}