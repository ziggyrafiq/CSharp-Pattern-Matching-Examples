
using PatternMatchingLibrary.Components;
using PatternMatchingLibrary.Components.Base;

namespace PatternMatchingLibrary;

public class ShapeInfoPrinter
{
    public void PrintShapeInfo(Shape shape)
    {
        if (shape is Circle circle)
        {
            Console.WriteLine($"Circle with radius {circle.Radius}");
        }
        else if (shape is Rectangle rectangle)
        {
            Console.WriteLine($"Rectangle with width {rectangle.Width} and height {rectangle.Height}");
        }
        else
        {
            Console.WriteLine("Unknown shape type");
        }
    }

    public string DescribeShape(Shape shape)
    {
        string description = shape switch
        {
            Circle circle => $"Circle with radius {circle.Radius}",
            Rectangle rectangle => $"Rectangle with width {rectangle.Width} and height {rectangle.Height}",
            null => "Shape is null",
            _ => "Unknown shape"
        };

        return description;
    }

    public string GetShapeDescription(IShape shape)
    {
        return shape switch
        {
            Circle circle when circle.Radius > 10 => $"Large circle with radius {circle.Radius}",
            Rectangle rectangle when rectangle.Width == rectangle.Height => $"Square with side length {rectangle.Width}",
            Triangle triangle => $"Triangle with base {triangle.Base} and height {triangle.Height}",
            _ => "Unknown shape"
        };
    }

}
