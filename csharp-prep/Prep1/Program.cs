using System;

class Program
{
    static void Main(string[] args)
    {/* Console.WriteLine("Hello Prep1 World!"); */

        Console.Write("What's your first name? ");
        string firstName = Console.ReadLine();

        Console.Write("What's your last name? ");
        string lastName = Console.ReadLine();

        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");

    }
}

