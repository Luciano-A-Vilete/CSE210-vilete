using System;

// This class represents an eternal goal, which is a type of goal that never gets completed.
public class EternalGoal : Goal
{
    // This variable keeps track of the number of steps taken towards this goal.
    private int _stepCounter;

    // This constructor creates a new eternal goal with default values.
    public EternalGoal()
    {
        _name = "";
        _description = "";
        _goalPoints = 50;
        _stepCounter = 0;
    }

    // This constructor creates a new eternal goal with the given name, description, and goal points.
    public EternalGoal(string name, string description, int goalPoints)
    {
        _name = name;
        _description = description;
        _goalPoints = goalPoints;
        _stepCounter = 0;
    }

    // This method creates a new child goal, which is a copy of this eternal goal.
    public override void CreateChildGoal()
    {
        CreateBaseGoal();
    }

    // This method lists this goal by printing its name and description to the console.
    public override void ListGoal()
    {
        Console.Write($"[ ] {_name} ({_description})");
    }

    // This method always returns false, indicating that this goal is never completed.
    public override bool IsComplete()
    {
        return false;
    }

    // This method saves this goal to a string, which includes its name, description, and goal points.
    public override string SaveGoal()
    {
        string line = "";
        line = $"EternalGoal:" + _name + "," + _description + "," + _goalPoints.ToString();
        return line;
    }

    // This method records an event, which increments the step counter by one.
    public override void RecordEvent()
    {
        _stepCounter++;
    }

    // This method calculates the adjusted goal points for this goal, which is simply the goal points.
    public override int CalculateAGP()
    {
        int points = _goalPoints;
        return points;
    }
}