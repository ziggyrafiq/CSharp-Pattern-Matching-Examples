using PatternMatchingLibrary.Components.Base;
using PatternMatchingLibrary.Components;

namespace PatternMatchingLibrary;

public static class ShapeMatcher
{
    public static void MatchShape(Shape shape)
    {
        switch (shape)
        {
            case Circle { Radius: > 10 }:
                Console.WriteLine("Large circle with radius greater than 10");
                break;
            case Rectangle { Width: var w, Height: var h } when w == h:
                Console.WriteLine("Square with side length equal to width and height");
                break;
            default:
                Console.WriteLine("Shape with unknown properties");
                break;
        }
    }

    public static string EvaluateShape(Shape shape)
    {
        return shape switch
        {
            Circle { Radius: > 10 } => "Large circle",
            Rectangle { Width: var w, Height: var h } when w == h => "Square",
            Rectangle { Width: var w, Height: var h } => $"Rectangle with width {w} and height {h}",
            _ => "Unknown shape"
        };
    }

    public static string ProcessShape(Shape shape)
    {
        string description = shape switch
        {
            Circle circle => $"Circle with radius {circle.Radius}",
            Rectangle rectangle => $"Rectangle with width {rectangle.Width} and height {rectangle.Height}",
            _ => "Unknown shape"
        };
        return description;
    }

    public static string ProcessShapes(IEnumerable<Shape> shapes)
    {
        string description = shapes switch
        {
            Shape[] array when array.Length == 0 => "Empty shape array",
            Shape[] array => $"Shape array with {array.Length} elements",
            List<Shape> list when list.Count == 0 => "Empty shape list",
            List<Shape> list => $"Shape list with {list.Count} elements",
            _ => "Unknown shapes collection"
        };
        return description;
    }

}