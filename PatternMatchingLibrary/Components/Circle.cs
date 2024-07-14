using PatternMatchingLibrary.Components.Base;

namespace PatternMatchingLibrary.Components;
public class Circle : Shape, IShape
{
    public double Radius { get; set; }
    public string ShapeType => "Circle";

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double Area()
    {
        return Math.PI * Radius * Radius;
    }
}
