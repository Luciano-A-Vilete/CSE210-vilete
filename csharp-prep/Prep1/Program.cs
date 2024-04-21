using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");

        Console.WriteLine("Tell me your first name, please? ");
        String firstName = Console.ReadLine();

        Console.WriteLine("Tell me your last name, please? ");
        String lastName = Console.ReadLine();

        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");

        
    }
}