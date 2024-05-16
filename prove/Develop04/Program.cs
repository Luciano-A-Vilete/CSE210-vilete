using System;

class Program
{
    static void Main(string[] args)
    {
        // Initialize input variable to store user's choice
        string input = "";

        // Initialize logs to track the number of times each activity is performed
        int breathingLog = 0;
        int reflectingLog = 0;
        int listingLog = 0;

        // Method to display the activity log
        void DisplayLog()
        {
            Console.WriteLine("Activity Log - Current Session");
            Console.WriteLine($"Breathing Activity: {breathingLog}");
            Console.WriteLine($"Reflecting Activity: {reflectingLog}");
            Console.WriteLine($"Listing Activity: {listingLog}");
            Console.WriteLine();
        }

        // Main loop to continuously prompt the user for input until they choose to quit
        while (input!= "4")
        {
            Console.Clear();
            DisplayLog();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");

            // Get the user's input
            input = Console.ReadLine();

            // Switch statement to handle different user inputs
            switch (input)
            {
                case "1":
                    // Create a new BreathingActivity object and run its activity
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.RunActivity();
                    breathingActivity.PromptBreathing();
                    breathingActivity.EndActivity();

                    // Increment the breathing log
                    breathingLog++;
                    break;

                case "2":
                    // Create a new ReflectingActivity object and run its activity
                    ReflectingActivity reflectingActivity = new ReflectingActivity();
                    reflectingActivity.RunActivity();
                    reflectingActivity.PromptReflecting();
                    reflectingActivity.EndActivity();

                    // Increment the reflecting log
                    reflectingLog++;
                    break;

                case "3":
                    // Create a new ListingActivity object and run its activity
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.RunActivity();
                    listingActivity.PromptListing();
                    listingActivity.EndActivity();

                    // Increment the listing log
                    listingLog++;
                    break;

                case "4":
                    // Exit the application
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Please enter the number of the menu option. ");
                    break;
            }
        }
        Environment.Exit(0);
    }
}