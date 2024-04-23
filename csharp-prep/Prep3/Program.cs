using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 15);
            int guess = -1;
            int guessCount = 0;
            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                if (magicNumber > guess)
                {
                    Console.WriteLine("Higher");
                }
                else if (magicNumber < guess)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
                guessCount++;

            }
            Console.WriteLine($"It took you {guessCount} guesses.");




        }
    }
}