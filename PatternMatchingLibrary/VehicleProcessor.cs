using PatternMatchingLibrary.Components.Base;
using PatternMatchingLibrary.Components;
namespace PatternMatchingLibrary;
public class VehicleProcessor
{
    public string ProcessVehicle(Vehicle vehicle)
    {
        return vehicle switch
        {
            Car car => $"Car with {car.NumberOfDoors} doors",
            Truck truck => $"Truck with payload capacity of {truck.PayloadCapacity} tons",
            Bicycle bicycle => $"Bicycle with {bicycle.NumWheels} wheels",
            _ => "Unknown vehicle type"
        };
    }

    public  string DescribeVehicle(Vehicle vehicle)
    {
        return vehicle switch
        {
            Car { NumberOfDoors: 4, EngineType: "Electric" } => "Electric car with 4 doors",
            Truck { PayloadCapacity: > 5000 } => "Heavy-duty truck",
            Bicycle { NumWheels: 2 } => "Bicycle",
            _ => "Unknown vehicle type"
        };
    }
}
