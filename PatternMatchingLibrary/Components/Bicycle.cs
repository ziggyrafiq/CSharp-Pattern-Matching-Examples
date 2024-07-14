using PatternMatchingLibrary.Components.Base;
namespace PatternMatchingLibrary.Components;
public class Bicycle : Vehicle
{
    public int NumWheels { get; set; }
    public override string GetDescription()
    {
        return $"This is a Bicycle standard description by Ziggy Rafiq and Bicycle with {NumWheels}";
    }
}
