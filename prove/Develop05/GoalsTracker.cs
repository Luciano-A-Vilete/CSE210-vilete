using System;
using System.IO;
using System.Collections.Generic; // Importing the System.Collections.Generic namespace for using List<T>

public class GoalsTracker
{
    // Private member variable to store the list of goals
    private List<Goal> _goals = new List<Goal>();

    // Private member variable to store the accumulated points
    private int _accumulatedPoints = 0;

    /// <summary>
    /// Returns the accumulated points.
    /// </summary>
    /// <returns>The accumulated points.</returns>
    public int GetAccumulatedPoints()
    {
        int points = _accumulatedPoints;
        return points;
    }

    /// <summary>
    /// Saves the goals to a file.
    /// </summary>
    public void SaveGoals()
    {
        string fileName = "";
        Console.Write("What is the filename? ");
        fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            int totalAGP = GetAccumulatedPoints();
            outputFile.WriteLine(totalAGP.ToString());

            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.SaveGoal());
            }
        }
    }

    /// <summary>
    /// Loads the goals from a file.
    /// </summary>
    public void LoadGoals()
    {
        _goals.Clear();

        string fileName = "";
        Console.Write("What is the filename? ");
        fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);

        _accumulatedPoints = Convert.ToInt32(lines[0]);

        for (int i = 1; i < lines.Count(); i++)
        {
            string[] parts = lines[i].Split("|");

            if (parts[0] == "SimpleGoal")
            {

                SimpleGoal simpleGoal = new SimpleGoal(parts[1], parts[2], Convert.ToInt32(parts[3]), Convert.ToBoolean(parts[4]));
                _goals.Add(simpleGoal);

            }
            else if (parts[0] == "EternalGoal")
            {

                EternalGoal eternalGoal = new EternalGoal(parts[1], parts[2], Convert.ToInt32(parts[3]));
                _goals.Add(eternalGoal);

            }
            else if (parts[0] == "ChecklistGoal")
            {

                ChecklistGoal checklistGoal = new ChecklistGoal(parts[1], parts[2], Convert.ToInt32(parts[3]), Convert.ToInt32(parts[4]), Convert.ToInt32(parts[5]), Convert.ToInt32(parts[6]));
                _goals.Add(checklistGoal);

            }
        }

    }

    /// <summary>
    /// Lists the goals.
    /// </summary>
    public void ListGoals()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count(); i++)
        {
            Console.Write($"{i + 1}. ");
            _goals[i].ListGoal();
            Console.Write("\n");
        }
        Console.WriteLine();
    }

    /// <summary>
    /// Adds a goal to the list of goals.
    /// </summary>
    /// <param name="goal">The goal to be added.</param>
    public void addGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    /// <summary>
    /// Calculates the total accumulated goal points.
    /// </summary>
    /// <returns>The total accumulated goal points.</returns>
    public int CalculateTotalAGP()
    {
        int totalAGP = _accumulatedPoints;
        foreach (Goal goal in _goals)
        {
            totalAGP += goal.CalculateAGP();
        }

        _accumulatedPoints = totalAGP;

        return totalAGP;
    }

    /// <summary>
    /// Records an event in the tracker.
    /// </summary>
    public void RecordEventInTracker()
    {
        string goalIndex = "";
        Console.Write("Which goal did you accomplish? ");
        goalIndex = Console.ReadLine();
        int goalIndexInt = Convert.ToInt32(goalIndex) - 1;

        if (_goals[goalIndexInt].IsComplete() == false)
        {

            _goals[goalIndexInt].RecordEvent();

            int pointsEarned = _goals[goalIndexInt].CalculateAGP();

            _accumulatedPoints += pointsEarned;

            Console.WriteLine($"Congratulations! You have earned {pointsEarned.ToString()} points!");
            Console.WriteLine($"You now have {_accumulatedPoints} points");

        }
        else
        {

            Console.WriteLine("You have already completed this goal.");

        }
    }
}