using System;
using System.Collections.Generic;

// The Activity class is an abstract base class for all types of activities.
public abstract class Activity
{
    // Date and Minutes are common properties for all activities.
    public DateTime Date { get; private set; }
    public double Minutes { get; private set; }

    // Constructor for the Activity class.
    public Activity(DateTime date, double minutes)
    {
        Date = date;
        Minutes = minutes;
    }

    // Abstract methods for getting the distance, speed, and pace.
    // These methods will be implemented in each derived class.
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    // GetSummary method returns a string with all the summary information.
    // This method is virtual, so it can be overridden in a derived class if needed.
    public virtual string GetSummary()
    {
        return $"{Date.ToString("dd MMM yyyy")} - {this.GetType().Name} ({Minutes} min) - Distance: {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}