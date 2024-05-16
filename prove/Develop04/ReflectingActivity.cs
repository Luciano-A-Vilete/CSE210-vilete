using System;
using System.Diagnostics;

public class ReflectingActivity : Activity
{
    // Private field to store the list of prompts for the reflecting activity
    private List<string> _prompts = new List<string> {
        "Think of a scenario where you stood up for someone else.",
        "Think of a situation when you faced a truly difficult task.",
        "Think of a moment when you extended help to someone in need.",
        "Think of an experience where you demonstrated genuine selflessness.",
        "Think of a time when you took a risk to support a worthy cause.",
        "Think of an occasion when you overcame a major obstacle through perseverance.",
        "Think of an incident where you went out of your way to make someone's day better.",
        "Think of a memory when you prioritized the needs of others above your own.",
        "Think of a moment when you confronted and addressed an injustice or unfairness.",
        "Think of an experience where you demonstrated exceptional empathy towards someone in distress.",
        "Think of a memory when you generously shared your knowledge or expertise to benefit others.",
    };

    // Private field to store the list of questions for the reflecting activity
    private List<string> _questions = new List<string> {
        "What differentiates this occasion from previous ones where you were less successful?",
        "What aspect of this experience resonated with you the most?",
        "What broader applications or lessons can you derive from this experience?",
        "What self-discoveries did you make through this encounter?",
        "How can you integrate the insights gained from this experience into future endeavors?",
        "What significance does this experience hold for you?",
        "Have you previously encountered a similar situation?",
        "What were the initial steps you took to initiate this process?",
        "How did you feel upon completing the task?",
    };

    // Default constructor to initialize the reflecting activity with default values
    public ReflectingActivity()
    {
        SetName("Reflecting Activity");
        SetDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
    }

    // Method to generate a random prompt for the reflecting activity
    public string GeneratePrompt()
    {
        Random random = new Random();
        int index = random.Next(0, _prompts.Count);
        return _prompts[index];
    }

    // Method to generate a random question for the reflecting activity
    public string GenerateQuestion()
    {
        Random random = new Random();
        int index = random.Next(0, _questions.Count);
        return _questions[index];
    }

    // Method to prompt the user to reflect on a specific prompt
    public void PromptReflecting()
    {
        // Generate a random prompt for the reflecting activity
        string prompt = GeneratePrompt();

        // Display the prompt to the user
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.Clear();

        // Calculate the future time based on the duration
        DateTime futureTime = GetFutureTime(GetDuration());

        // Get the current time
        DateTime currentTime = GetCurrentTime();

        // Loop until the future time is reached
        while (currentTime <= futureTime) {
            // Generate a random question for the reflecting activity
            string question = GenerateQuestion();

            // Display the question to the user
            Console.Write(question + " ");
            GenerateSpinner(15);
            Console.WriteLine();
            currentTime = DateTime.Now;currentTime = DateTime.Now;
        }
    }
}