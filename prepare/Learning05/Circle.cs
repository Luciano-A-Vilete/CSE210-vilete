public class Circle : Shape{
    private double _radius;

    public Circle(string color, double radius) : base(color){
        _radius = radius;
    }

    public override double GetArea()
    {
        return (_radius * 2) * Math.PI;
    }
}