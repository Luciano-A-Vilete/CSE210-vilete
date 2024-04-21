using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.WriteLine("Tell me your final grade, without points, please: ");
        String grade = Console.ReadLine();
        int gradeInt = int.Parse(grade);

        string letter = "";

        //grade condition
        if (gradeInt >= 90)
        {
            letter = "A";
        }
        else if (gradeInt >= 80)
        {
            letter = "B";
        }
        else if (gradeInt >= 70)
        {
            letter = "C";
        }
        else if (gradeInt >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        //Showing the grade
        Console.WriteLine($"Your final grade is: {letter}");

        //final message
        if (gradeInt >= 70) 
        {
            Console.WriteLine("Congratulations! You passed!");
        }
        else {
            Console.WriteLine("Sorry, you failed. But you can try harder the next period!");
        }


    }
}