public class Cycling : Activity
{
    private double SpeedInKilometersPerHour { get; } 

    public Cycling(DateTime date, double minutes, double speed) 
        : base(date, minutes)
    {
        SpeedInKilometersPerHour = speed;
    }

    public override double GetDistance()
    {
        return CalculateDistanceInKilometers();
    }

    public override double GetSpeed()
    {
        return SpeedInKilometersPerHour;
    }

    public override double GetPace()
    {
        return CalculatePaceInMinutesPerKilometer();
    }

    private double CalculateDistanceInKilometers()
    {
        return (SpeedInKilometersPerHour / 60) * Minutes; 
    }

    private double CalculatePaceInMinutesPerKilometer()
    {
        return 60 / SpeedInKilometersPerHour; 
    }
}