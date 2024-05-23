using System;

class Program
{
    static void Main(string[] args)
    {
        // Initialize a string variable to store the user's menu selection
        string menuSelected = "";

        // Instantiate a new GoalsTracker object
        GoalsTracker goals = new GoalsTracker();

        // Loop through the menu options until the user selects option 6 (Quit)
        while (menuSelected!= "6")
        {

            // Get the total number of points accumulated in the GoalsTracker
            int points = goals.GetAccumulatedPoints();

            // Display the number of points and the menu options
            Console.WriteLine($"You have {points} points.");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");

            // Get the user's menu selection
            menuSelected = Console.ReadLine();

            // Switch on the user's menu selection
            switch (menuSelected)
            {
                case "1":

                    // Display the types of goals that can be created
                    Console.WriteLine("The Types of Goals are: ");
                    Console.WriteLine("  1. Simple Goal");
                    Console.WriteLine("  2. Eternal Goal");
                    Console.WriteLine("  3. Checklist Goal");
                    Console.Write("Which type of goal would you like to create? ");

                    // Get the type of goal the user wants to create
                    string goalType = Console.ReadLine();

                    // Switch on the type of goal the user wants to create
                    switch (goalType)
                    {
                        case "1":
                            // Create a new SimpleGoal object and add it to the GoalsTracker
                            SimpleGoal newSimpleGoal = new SimpleGoal();
                            newSimpleGoal.CreateChildGoal();
                            goals.addGoal(newSimpleGoal);
                            break;

                        case "2":
                            // Create a new EternalGoal object and add it to the GoalsTracker
                            EternalGoal newEternalGoal = new EternalGoal();
                            newEternalGoal.CreateChildGoal();
                            goals.addGoal(newEternalGoal);
                            break;

                        case "3":
                            // Create a new ChecklistGoal object and add it to the GoalsTracker
                            ChecklistGoal newChecklistGoal = new ChecklistGoal();
                            newChecklistGoal.CreateChildGoal();
                            goals.addGoal(newChecklistGoal);
                            break;

                        default:
                            Console.WriteLine("Invalid goal type. Please try again.");
                            break;
                    }
                    break;

                case "2":
                    // List all of the goals in the GoalsTracker
                    goals.ListGoals();
                    break;

                case "3":
                    // Save the goals in the GoalsTracker to a file
                    goals.SaveGoals();
                    break;

                case "4":
                    // Load goals from a file into the GoalsTracker
                    goals.LoadGoals();
                    break;

                case "5":
                    // Record an event in the GoalsTracker
                    goals.RecordEventInTracker();
                    break;

                case "6":
                    // Exit the program
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Please select a valid number from the menu options.");
                    break;
            }
        }
    }
}