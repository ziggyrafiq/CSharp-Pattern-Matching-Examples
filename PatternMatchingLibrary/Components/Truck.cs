using PatternMatchingLibrary.Components.Base;
namespace PatternMatchingLibrary.Components;
public class Truck : Vehicle
{
    public double PayloadCapacity { get; set; }

    public override string GetDescription()
    {
        return "This is a truck standard description by Ziggy Rafiq";
    }
}
