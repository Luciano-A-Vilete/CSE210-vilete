using System;

public class ChecklistGoal : Goal
{
    // The bonus points received when the checklist goal is accomplished the specified number of times.
    private int _bonusPoints;
    // The number of times the goal needs to be accomplished to receive a bonus.
    private int _steps;
    // The current count of how many times the goal has been accomplished.
    private int _stepCounter;

    // Default constructor for ChecklistGoal.
    public ChecklistGoal()
    {

    }

    // Constructor for ChecklistGoal, initializes the goal with a name, description, goal points, bonus points, and steps.
    public ChecklistGoal(string name, string description, int goalPoints, int bonusPoints, int steps, int stepCounter)
    {
        _name = name;
        _description = description;
        _goalPoints = goalPoints;
        _bonusPoints = bonusPoints;
        _steps = steps;
        _stepCounter = stepCounter;
    }

    // Creates a child goal and prompts the user to input the number of steps required for a bonus and the bonus points.
    public override void CreateChildGoal()
    {
        CreateBaseGoal();

        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        string stringChecklistSteps = Console.ReadLine();
        _steps = Convert.ToInt32(stringChecklistSteps);

        Console.Write("What is the bonus for accomplishing it that many times? ");
        string bonusPoints = Console.ReadLine();
        _bonusPoints = Convert.ToInt32(bonusPoints);

        _stepCounter = 0;

    }

    // Checks if the checklist goal is complete by comparing the current step count to the required steps.
    public override bool IsComplete() 
    {
        if (_stepCounter >= _steps) {
            return true;
        } else {
            return false;
        }
    }
    
    // Increments the step counter when an event is recorded.
    public override void RecordEvent()
    {
        _stepCounter ++;
    }

    // Calculates the advanced goal points (AGP) based on the current step count and bonus points.
    public override int CalculateAGP()
    {
        int points = 0;

        points = _stepCounter * _goalPoints;

        bool status = IsComplete();

        if (status == true) {
            points += _bonusPoints;
        }

        return points;

    }

    // Lists the goal with its current status, showing the number of completed steps.
    public override void ListGoal()
    {
        string statusSymbol = "";
        bool status = IsComplete();
        if (status == true) {
            statusSymbol = "X";
        } else {
            statusSymbol = " ";
        }

        Console.Write($"[{statusSymbol}] {_name} ({_description}) -- Currently Completed {_stepCounter}/{_steps}");
    }

    // Saves the goal to a string, including its name, description, goal points, bonus points, steps, and current step count.
    public override string SaveGoal()
    {
        string line = "";
        line = $"ChecklistGoal:" + _name + "," + _description + "," + _goalPoints.ToString() + "," + _bonusPoints.ToString() + "," + _steps.ToString() + "," + _stepCounter.ToString();
        return line;
    }

}