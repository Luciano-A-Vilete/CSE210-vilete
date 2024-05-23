using System;

public class SimpleGoal : Goal
{
    // Default constructor for a SimpleGoal object
    public SimpleGoal()
    {
        // Set the name of the goal
        _name = "Name of Simple Goal";
        // Set the description of the goal
        _description = "Description of Simple Goal";
        // Set the goal points for the goal
        _goalPoints = 50;
        // Set the status of the goal to incomplete
        _status = false;
    }

    // Parameterized constructor for a SimpleGoal object
    public SimpleGoal(string name, string description, int goalPoints, bool status)
    {
        // Set the name of the goal
        _name = name;
        // Set the description of the goal
        _description = description;
        // Set the goal points for the goal
        _goalPoints = goalPoints;
        // Set the status of the goal
        _status = status;
    }

    // Method to create a child goal (calls CreateBaseGoal())
    public override void CreateChildGoal()
    {
        CreateBaseGoal();
    }

    // Method to record an event for the goal
    public override void RecordEvent()
    {
        // If the goal is not complete, mark it as complete
        if (_status == false) {
            _status = true;
        } 
        // If the goal is already complete, display a message
        else {
            Console.WriteLine("You have already completed this goal.");
        }
    }

    // Method to check if the goal is complete
    public override bool IsComplete()
    {
        // Return true if the goal is complete, false otherwise
        if (_status == true) {
            return true;
        } else {
            return false;
        }
    }

    // Method to list the goal
    public override void ListGoal()
    {
        // Initialize a string to hold the status symbol
        string statusSymbol = "";
        // Check if the goal is complete
        bool status = IsComplete();
        // Set the status symbol based on the goal's status
        if (status == true) {
            statusSymbol = "X";
        } else {
            statusSymbol = " ";
        }
        // Print the goal details
        Console.Write($"[{statusSymbol}] {_name} ({_description})");
    }

    // Method to calculate the adjusted goal points (AGP)
    public override int CalculateAGP()
    {
        // Check if the goal is complete
        bool status = IsComplete();
        // Initialize the adjusted goal points to 0
        int aGP = 0;
        // If the goal is complete, set the AGP to the goal points
        if (status == true) {
            aGP = _goalPoints;
        } 
        // If the goal is not complete, set the AGP to 0
        else {
            aGP = 0;
        }
        // Return the adjusted goal points
        return aGP;
    }

    // Method to save the goal to a string
    public override string SaveGoal()
    {
        // Initialize a string to hold the goal details
        string line = "";
        // Format the goal details into a string
        line = $"SimpleGoal:{_name},{_description}{_goalPoints},{IsComplete().ToString()}";
        // Return the formatted string
        return line;
    }
}