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

        string choice = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(choice))
        {
            Console.WriteLine("No input received. Exiting...");
            return;
        }

        switch (choice)
        {
            case "1":
                Animal a = new Animal();
                Animal d = new Dog();
                Animal c = new Cat();
                Console.WriteLine("\nAnimal:");
                a.MakeSound();
                Console.WriteLine("Dog:");
                d.MakeSound();
                Console.WriteLine("Cat:");
                c.MakeSound();
                break;
            case "2":
                Shape circle = new Circle(5);
                Shape rectangle = new Rectangle(4, 6);
                Console.WriteLine($"Circle Area: {circle.GetArea():F2}");
                Console.WriteLine($"Rectangle Area: {rectangle.GetArea():F2}");
                break;

        }
    }
}