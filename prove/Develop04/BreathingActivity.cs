using System;
using System.Diagnostics;

public class BreathingActivity : Activity
{
    // Default constructor to initialize the breathing activity with default values
    public BreathingActivity()
    {
        SetName("Breathing Activity");
        SetDescription("This activity will help you relax by walking through your breathing in and out slowly. Clear your mind and focus on your breathing.");
    }

    // Method to prompt the user to breathe in and out
    public void PromptBreathing()
    {
        // Calculate the future time based on the duration
        DateTime futureTime = GetFutureTime(GetDuration());

        // Get the current time
        DateTime currentTime = GetCurrentTime();

        // Loop until the future time is reached
        while (currentTime <= futureTime)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Breathe in...");
            GenerateCountdownTimer(2);
            Console.WriteLine();
            Console.Write("Breathe out...");
            GenerateCountdownTimer(3);
            currentTime = DateTime.Now;
        }
    }
}