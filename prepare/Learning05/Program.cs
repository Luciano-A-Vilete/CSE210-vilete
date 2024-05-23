using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square1 = new Square("green", 3);
        shapes.Add(square1);

        Rectangle rectangle1 = new Rectangle("violet", 3.5, 5.8);
        shapes.Add(rectangle1);

        Circle circle1 = new Circle("Brown", 5.3);
        shapes.Add(circle1);

        foreach (Shape s in shapes){
            string color = s.GetColor();

            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}");
        }
    }
}