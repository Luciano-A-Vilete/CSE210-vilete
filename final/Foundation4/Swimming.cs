public class Swimming : Activity
{
    private int NumberOfLaps { get; } 

    public Swimming(DateTime date, double minutes, int numberOfLaps) 
        : base(date, minutes)
    {
        NumberOfLaps = numberOfLaps;
    }

    public override double GetDistance()
    {
        return CalculateDistanceInKilometers();
    }

    public override double GetSpeed()
    {
        return CalculateSpeedInKilometersPerHour();
    }

    public override double GetPace()
    {
        return CalculatePaceInMinutesPerKilometer();
    }

    private double CalculateDistanceInKilometers()
    {
        return NumberOfLaps * 50.0 / 1000; 
    }

    private double CalculateSpeedInKilometersPerHour()
    {
        return (GetDistance() / Minutes) * 60; 
    }

    private double CalculatePaceInMinutesPerKilometer()
    {
        return Minutes / GetDistance(); 
    }
}