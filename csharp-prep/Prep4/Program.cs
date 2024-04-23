using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        List<int> numbers = new List<int>();

        Console.WriteLine("Add a number to the list: (type 0 to finish) ");
        string strNumber = Console.ReadLine();
        int number = int.Parse(strNumber);

        while (number!= 0)
        {
            Console.WriteLine("Add a number to the list: (type 0 to finish) ");

            numbers.Add(number);
            strNumber = Console.ReadLine();
            number = int.Parse(strNumber);
        }

        int sum = numbers.Sum();
        Console.WriteLine($"The sum of the numbers is: {sum}");

        double average = numbers.Average();
        Console.WriteLine($"The average of the numbers is: {average}");

        int max = numbers.Max();
        Console.WriteLine($"The maximum number is: {max}");

        int minPositive = numbers.Where(n => n > 0).Min();
        Console.WriteLine($"The smallest positive number is: {minPositive}");

        numbers.Sort();
        Console.WriteLine($"Sorted list: {string.Join(", ", numbers)}");
    }
}