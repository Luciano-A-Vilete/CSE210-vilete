public class Running : Activity
{
    // Distance is a specific property for Running.
    public double Distance { get; private set; }

    // Constructor for the Running class.
    public Running(DateTime date, double minutes, double distance) : base(date, minutes)
    {
        Distance = distance;
    }

    // Overridden methods for getting the distance, speed, and pace.
    public override double GetDistance() => Distance;
    public override double GetSpeed() => (Distance / Minutes) * 60;
    public override double GetPace() => Minutes / Distance;
}