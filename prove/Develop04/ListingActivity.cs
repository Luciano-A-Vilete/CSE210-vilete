using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    // Private field to store the list of prompts for the listing activity
    private List<string> _prompts = new List<string> {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
        "What are some attributes that you admire in others?",
        "When was the last time you felt a deep sense of gratitude?",
    };

    // Default constructor to initialize the listing activity with default values
    public ListingActivity()
    {
        SetName("Listing Activity");
        SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
    }

    // Method to generate a random prompt for the listing activity
    public string GeneratePrompt()
    {
        // Create a new instance of the Random class
        Random random = new Random();

        // Generate a random index within the range of the prompts list
        int index = random.Next(0, _prompts.Count);

        // Return the prompt at the generated index
        return _prompts[index];
    }

    // Method to prompt the user to list responses to a specific prompt
    public void PromptListing()
    {
        // Generate a random prompt for the listing activity
        string prompt = GeneratePrompt();

        // Display the prompt to the user
        Console.WriteLine();
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"--- {prompt} ---");
        Console.Write("You may begin in: ");

        // Generate a countdown timer to indicate the start of the activity
        GenerateCountdownTimer(5);

        Console.WriteLine();

        // Calculate the future time based on the duration
        DateTime futureTime = GetFutureTime(GetDuration());

        // Get the current time
        DateTime currentTime = GetCurrentTime();

        // Loop until the future time is reached
        while (currentTime <= futureTime)
        {
            Console.Write(">");
            Console.ReadLine();
            currentTime = DateTime.Now;
        }
    }
}