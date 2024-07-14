using PatternMatchingLibrary.Components.Base;

namespace PatternMatchingLibrary.Components;

public class Rectangle : Shape, IShape
{
    public double Width { get; set; }
    public double Height { get; set; }
    public string ShapeType => "Rectangle";
    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }
        public override double Area()
    {
        return Width * Height;
    }
}


