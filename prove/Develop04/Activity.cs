using System;
using System.Diagnostics;

public class Activity
{
    // Private field to store the name of the activity
    private string _name;
    
    // Private field to store the description of the activity
    private string _description;
    
    // Private field to store the duration of the activity in seconds
    private int _duration;

    // Default constructor to initialize the activity with default values
    public Activity()
    {
        _name = "";
        _description = "";
        _duration = 15;
    }

    // Method to set the name of the activity
    public void SetName(string name)
    {
        _name = name;
    }

    // Method to set the description of the activity
    public void SetDescription(string description)
    {
        _description = description;
    }

    // Method to display the details of the activity
    public void ShowDetails()
    {
        // Welcome message with the activity name
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        
        // Display the activity description
        Console.WriteLine(_description);
    }

    // Method to ask the user for the duration of the activity
    public void AskDuration()
    {
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        
        // Read the user's input and convert it to an integer
        string durationString = Console.ReadLine();
        SetDuration(Convert.ToInt32(durationString));
    }

    // Method to set the duration of the activity
    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    // Method to get the duration of the activity
    public int GetDuration()
    {
        return _duration;
    }

    // Method to run the activity
    public void RunActivity()
    {
        // Clear the console
        Console.Clear();
        
        // Display the activity details
        ShowDetails();
        
        // Ask the user for the duration
        AskDuration();
        
        // Get ready to start the activity
        GetReady();
    }

    // Method to end the activity
    public void EndActivity()
    {
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine($"Well done!!");
        
        // Generate a spinner to indicate the end of the activity
        GenerateSpinner(5);
        
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        
        // Generate another spinner to indicate the end of the activity
        GenerateSpinner(5);
    }

    // Method to generate a spinner to indicate the progress of the activity
    public void GenerateSpinner(int totalSeconds)
    {
        int spinnerPosition = 25;
        int spinWait = 500;

        spinnerPosition = Console.CursorLeft;

        // Calculate the future time based on the total seconds
        DateTime futureTime = GetFutureTime(5);

        // Loop until the future time is reached
        while (DateTime.Now < futureTime)
        {
            char[] spinChars = new char[] { '|', '/', '-', '\\' };
            foreach (char spinChar in spinChars)
            {
                Console.CursorLeft = spinnerPosition;
                Console.Write(spinChar);
                Thread.Sleep(spinWait);
            }
        }
        Console.CursorLeft = spinnerPosition;
        Console.Write(" ");
    }

    // Method to generate a countdown timer to indicate the progress of the activity
    public void GenerateCountdownTimer(int totalSeconds)
    {
        int timerPosition = 25;
        int timerWait = 1000;

        timerPosition = Console.CursorLeft;

        // Loop from 0 to the total seconds
        for (int i = 0; i <= totalSeconds; i++)
        {
            Console.CursorLeft = timerPosition;
            Console.Write(totalSeconds - i);
            Thread.Sleep(timerWait);
        }
        Console.CursorLeft = timerPosition;
        Console.Write(" ");
    }

    // Method to get ready to start the activity
    public void GetReady()
    {
        Console.Clear();
        Console.WriteLine("Get Ready...");
        
        // Generate a spinner to indicate the start of the activity
        GenerateSpinner(5);
    }

    // Method to get the future time based on the duration
    public DateTime GetFutureTime(int duration)
    {
        DateTime futureTime = new DateTime();
        futureTime = DateTime.Now.AddSeconds(duration);

        return futureTime;
    }

    // Method to get the current time
    public DateTime GetCurrentTime()
    {
        DateTime currentTime = new DateTime();
        currentTime = DateTime.Now;
        return currentTime;
    }
}