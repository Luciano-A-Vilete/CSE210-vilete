using System;

public class Goal
{
    // Name of the goal
    protected string _name;

    // Description of the goal
    protected string _description;

    // Points associated with the goal
    protected int _goalPoints;

    // Status of the goal (true if completed, false otherwise)
    protected bool _status;

    // Constructor for the Goal class
    public Goal() 
    {
        _name = "Test Name";
        _description = "Test Description";
        _goalPoints = 50;
        _status = false;
    }

    // Overloaded constructor for the Goal class
    public Goal(string name, string description, int goalPoints)
    {
        _name = name;
        _description = description;
        _goalPoints = goalPoints;
    }

    // Method to create a base goal
    protected void CreateBaseGoal() 
    {   
        Console.Write("What is the name of your goal? ");
        _name = Console.ReadLine();
        
        Console.Write("What is a short description of it? ");
        _description = Console.ReadLine();
        
        Console.Write("What is the amount of points associated with this goal? ");
        string stringGoalPoints = (Console.ReadLine());
        _goalPoints = Convert.ToInt32(stringGoalPoints);

        _status = false;
    }

    // Virtual method to save the goal
    public virtual string SaveGoal()
    {
        string line = "";
        return line;
    }

    // Virtual method to create a child goal
    public virtual void CreateChildGoal()
    {

    }

    // Virtual method to record an event
    public virtual void RecordEvent() 
    {

    }

    // Virtual method to check if the goal is complete
    public virtual bool IsComplete() 
    {
        return false;
    }

    // Virtual method to list the goal
    public virtual void ListGoal() 
    {

    }

    // Virtual method to calculate the adjusted goal points
    public virtual int CalculateAGP()
    {
        return 0;
    }
}