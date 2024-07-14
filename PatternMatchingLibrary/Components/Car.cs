using PatternMatchingLibrary.Components.Base;
namespace PatternMatchingLibrary.Components;
public class Car : Vehicle
{
    public int NumberOfDoors { get; set; }
    public string EngineType { get; set; }=string.Empty;
    public override string GetDescription()
    {
        return $"This is a car standard description by Ziggy Rafiq and car with {NumberOfDoors}";
    }
}
