namespace PatternMatchingLibrary.Components.Base;
public abstract  class Vehicle
{
    public string Manufacturer { get; set; } = string.Empty;
    public string Model { get; set; } = string.Empty;
    public int Year { get; set; } = 0;
    public abstract string GetDescription();
}
