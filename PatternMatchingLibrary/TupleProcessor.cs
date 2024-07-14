namespace PatternMatchingLibrary;

public class TupleProcessor
{
    public string ProcessTuple((int x, int y) point)
    {
        string quadrant = point switch
        {
            (0, 0) => "Origin",
            (var x, var y) when x > 0 && y > 0 => "First quadrant",
            (var x, var y) when x < 0 && y > 0 => "Second quadrant",
            (var x, var y) when x < 0 && y < 0 => "Third quadrant",
            (var x, var y) when x > 0 && y < 0 => "Fourth quadrant",
            (_, _) => "On axis"
        };
        return quadrant;
    }
}