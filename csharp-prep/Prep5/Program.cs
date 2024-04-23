using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");

        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(userNumber);
        DisplayResult(userName, squaredNumber);
    }

    static void DisplayWelcome()
    {
        // Displays the welcome message
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        // Asks for and returns the user's name
        Console.Write("Enter your name: ");
        return Console.ReadLine();
    }

    static int PromptUserNumber()
    {
        // Asks for and returns the user's favorite number
        Console.Write("Enter your favorite number: ");
        return Convert.ToInt32(Console.ReadLine());
    }

    static int SquareNumber(int number)
    {
        // Accepts an integer as a parameter and returns that number squared
        return number * number;
    }

    static void DisplayResult(string userName, int squaredNumber)
    {
        // Accepts the user's name and the squared number and displays them
        Console.WriteLine($"Hello, {userName}! Your favorite number squared is: {squaredNumber}");
    }
}
