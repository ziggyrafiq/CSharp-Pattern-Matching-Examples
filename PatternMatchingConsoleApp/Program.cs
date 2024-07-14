
using PatternMatchingLibrary;
using PatternMatchingLibrary.Components;
using PatternMatchingLibrary.Components.Base;
using PatternMatchingLibrary.Models;

Console.WriteLine("Hello, Welcome to C# Different Types of Pattern Matching Book Code Examples by Ziggy Rafiq");
Console.WriteLine("Please do not forget to follow me on LinkedIn https://www.linkedin.com/in/ziggyrafiq/");
Console.WriteLine("Please Click Any Key To Carry On Seeing the Code Examples");


var point = new Point(3, 4);
switch (point)
{
    case Point p when p.X == 0 && p.Y == 0:
        Console.WriteLine("Origin");
        break;
    case Point p when p.X != 0 && p.Y == 0:
        Console.WriteLine($"Point on x-axis at {p.X}");
        break;
    case Point p when p.X == 0 && p.Y != 0:
        Console.WriteLine($"Point on y-axis at {p.Y}");
        break;
    case Point p when p.X == p.Y:
        Console.WriteLine($"Point on diagonal at ({p.X}, {p.Y})");
        break;
    default:
        Console.WriteLine($"Arbitrary point ({point.X}, {point.Y})");
        break;
}



Shape shape = new Circle(5.0);

if (shape is Circle circle)
{
    Console.WriteLine($"Circle with radius {circle.Radius}");
}

switch (shape)
{
    case Circle { Radius: > 10 }:
        Console.WriteLine("Large circle with radius greater than 10");
        break;
    case Rectangle { Width: var w, Height: var h } when w == h:
        Console.WriteLine("Square with side length equal to width and height");
        break;
}

Console.WriteLine("Please Click Any Key To Carry On Seeing the Code Examples");
Console.ReadLine();

var pointTuple = (10, 14);

string location = pointTuple switch
{
    (0, 0) => "Origin",
    (var x, 0) => $"Point on x-axis at {x}",
    (0, var y) => $"Point on y-axis at {y}",
    _ => $"Arbitrary point ({pointTuple.Item1}, {pointTuple.Item2})"
};

Console.WriteLine(location);
Console.WriteLine("Please Click Any Key To Carry On Seeing the Code Examples");
Console.ReadLine();

var shape2 = new Circle(radius: 45);  
string shapeType = shape2 switch
{
    Circle c when c.Radius > 10 => "Large circle",
    _ => "Unknown shape"
};

Console.WriteLine(shapeType);
Console.WriteLine("Please Click Any Key To Carry On Seeing the Code Examples");
Console.ReadLine();

object objectOne = 44;
object objectTwo = new List<int> { 17, 52, 23 };
object objectThree = new List<object> { 4, new List<int> { 5, 6 }, 7 };

Console.WriteLine(Numbers.SumNumbers(objectOne)); 
Console.WriteLine(Numbers.SumNumbers(objectTwo)); 
Console.WriteLine(Numbers.SumNumbers(objectThree));

var dayChecker = new DayOfWeekChecker();
Console.WriteLine(dayChecker.GetDayOfWeek(DayOfWeek.Monday)); 
Console.WriteLine(dayChecker.GetDayOfWeek(DayOfWeek.Friday)); 
Console.WriteLine(dayChecker.GetDayOfWeek(DayOfWeek.Wednesday));

Console.WriteLine("Please Click Any Key To Carry On Seeing the Code Examples");
Console.ReadLine();

ShapeInfoPrinter shapeInfoPrinter = new ShapeInfoPrinter();

Circle circleTypePatternMatching = new Circle(45);
Rectangle rectangleTypePatternMatching = new Rectangle(13,54);
Shape? nullShapeTypePatternMatching = null;


Console.WriteLine(shapeInfoPrinter.DescribeShape(circleTypePatternMatching));    
Console.WriteLine(shapeInfoPrinter.DescribeShape(rectangleTypePatternMatching)); 
Console.WriteLine(shapeInfoPrinter.DescribeShape(nullShapeTypePatternMatching));

Console.WriteLine("Please Click Any Key To Carry On Seeing the Code Examples");
Console.ReadLine();

VehicleProcessor processor = new VehicleProcessor();

Car car = new Car
{
    Manufacturer = "Toyota",
    Model = "Camry",
    Year = 2024,
    NumberOfDoors = 4
};

Console.WriteLine(car.GetDescription());
Console.WriteLine(processor.ProcessVehicle(car));

Truck truck = new Truck
{
    Manufacturer = "Ford",
    Model = "F-150",
    Year = 2012,
    PayloadCapacity = 3.5
};

Console.WriteLine(truck.GetDescription());
Console.WriteLine(processor.ProcessVehicle(truck));

Bicycle bicycle = new Bicycle
{
    Manufacturer = "Schwinn",
    Model = "Mountain Bike",
    Year = 2023,
    NumWheels = 2
};
Console.WriteLine(bicycle.GetDescription());
Console.WriteLine(processor.ProcessVehicle(bicycle));
Console.WriteLine("Please Click Any Key To Carry On Seeing the Code Examples");
Console.ReadLine();

IShape[] shapes =
           [
                new Circle(radius: 5),
                new Rectangle(width: 4, height: 4),
                new Triangle(@base: 3, height: 5)
           ];

 

foreach (var shapeInfo in shapes)
{
    Console.WriteLine(shapeInfoPrinter.GetShapeDescription(shapeInfo));
}
Console.WriteLine("Please Click Any Key To Carry On Seeing the Code Examples");
Console.ReadLine();

Shape[] shapeInformation =
{
    new Circle(radius: 15),
    new Rectangle(width: 10, height: 10),
    new Rectangle(width: 8, height: 6),
    
};

foreach (var shapeDetials in shapeInformation)
{
    var description = ShapeMatcher.EvaluateShape(shapeDetials);
    Console.WriteLine($"Shape: {shapeDetials.GetType().Name}, Description: {description}");
}
Console.WriteLine("Please Click Any Key To Carry On Seeing the Code Examples");
Console.ReadLine();

var person1 = ("Mike", "Smith");
var person2 = ("Lisa", "Hills");
var person3 = ("Lerzan", "Hakim");

Console.WriteLine(PersonMatcher.EvaluatePerson(person1));
Console.WriteLine(PersonMatcher.EvaluatePerson(person2));
Console.WriteLine(PersonMatcher.EvaluatePerson(person3));

var vehicles = new Vehicle[]
        {
            new Car { NumberOfDoors = 4, EngineType = "Electric" },
            new Truck { PayloadCapacity = 6000 },
            new Bicycle { NumWheels = 2 },
            new Car { NumberOfDoors = 2, EngineType = "Gasoline" }
        };

foreach (var vehicle in vehicles)
{
    Console.WriteLine(processor.DescribeVehicle(vehicle));
}
Console.WriteLine("Please Click Any Key To Carry On Seeing the Code Examples");
Console.ReadLine();

Shape[] shapesArray = new Shape[]
        {
            new Circle(13),
            new Rectangle(14,37)
        };

foreach (var shapeList in shapesArray)
{
    Console.WriteLine(ShapeMatcher.ProcessShape(shapeList));
}

List<Shape> shapesList = new List<Shape>
        {
            new Circle(19),
            new Rectangle(34,23)
        };

Console.WriteLine(ShapeMatcher.ProcessShapes(shapesList));
Console.WriteLine("Please Click Any Key To Carry On Seeing the Code Examples");
Console.ReadLine();


List<int> intList = new List<int> { 1, 2, 3, 4, 5 };
List<string> stringList = new List<string> { "apple", "banana", "cherry" };
object[] emptyArray = Array.Empty<object>();
IEnumerable<object> nullData = null;

var analyzer = new DataAnalyzer();
Console.WriteLine(analyzer.AnalyzeData(intList.Cast<object>()));
Console.WriteLine(analyzer.AnalyzeData(stringList));  
Console.WriteLine(analyzer.AnalyzeData(emptyArray));  
Console.WriteLine(analyzer.AnalyzeData(nullData));
Console.WriteLine("Please Click Any Key To Carry On Seeing the Code Examples");
Console.ReadLine();


Console.WriteLine(NumberSummarizer.EvaluateNumber(15));
Console.WriteLine(NumberSummarizer.EvaluateNumber(-1));
Console.WriteLine(NumberSummarizer.EvaluateNumber(42)); 
Console.WriteLine(NumberSummarizer.EvaluateNumber(15)); 
Console.WriteLine(NumberSummarizer.EvaluateNumber(200));
Console.WriteLine(NumberSummarizer.EvaluateNumber(100));
Console.WriteLine("Please Click Any Key To Carry On Seeing the Code Examples");
Console.ReadLine();

Console.WriteLine(UserInputValidation.ValidateUserInput(null));         
Console.WriteLine(UserInputValidation.ValidateUserInput(""));           
Console.WriteLine(UserInputValidation.ValidateUserInput("Valid input"));
Console.WriteLine(UserInputValidation.ValidateUserInput("Too long input that exceeds 20 characters"));   
Console.WriteLine(UserInputValidation.ValidateUserInput("admin"));         
Console.WriteLine(UserInputValidation.ValidateUserInput("administrator"));
Console.WriteLine("Please Click Any Key To Carry On Seeing the Code Examples");
Console.ReadLine();


var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

var evenNumbers = from num in numbers
                  where num % 2 == 0
                  select num;

var specialNumbers = from num in numbers
                     where num >= 5 && num <= 8
                     select num;

Console.WriteLine("Even Numbers:");
foreach (var num in evenNumbers)
{
    Console.Write(num + " ");
}
Console.WriteLine();


Console.WriteLine("Special Numbers (between 5 and 8 inclusive):");
foreach (var num in specialNumbers)
{
    Console.Write(num + " ");
}
Console.WriteLine();

Console.WriteLine("Please Click Any Key To Carry On Seeing the Code Examples");
Console.ReadLine();

var names = new List<string> { "Alice", "Bob", "Charlie", "David", "Eve" };
var shortNames = from name in names
                 where name.Length < 5
                 select name;


Console.WriteLine("Short Names (length < 5):");
foreach (var name in shortNames)
{
    Console.Write(name + " ");
}
Console.WriteLine();

var personList = PersonMatcher.GetPersonsStartingWithA();
Console.WriteLine("The Persons who name start with A are as following below.");
foreach (var person in personList)
{
    Console.WriteLine($"{person.FirstName}{person.LastName}");
}
Console.WriteLine("Please Click Any Key To Carry On Seeing the Code Examples");
Console.ReadLine();


string url = "https://ziggyrafiq.com";
using var httpClient = new HttpClient();
var dataFetcher = new PatternMatchingLibrary.Data.Fetcher(httpClient);
try
{
    string result = await dataFetcher.FetchDataAsync(url);
    Console.WriteLine($"Data fetched successfully:\n{result}");
}
catch (Exception ex)
{
    Console.WriteLine($"Error occurred: {ex.Message}");
}

Console.WriteLine("Please Click Any Key To Carry On Seeing the Code Examples");
Console.ReadLine();

try
{
    Console.WriteLine("Example 1:");
    Console.WriteLine($"Result is {await Numbers.DivideAsync(14, 3)}");

    Console.WriteLine("Example 2:");
    Console.WriteLine($"Result is {await Numbers.DivideAsync(15, 2)}");

    Console.WriteLine("Example 3:");
    Console.WriteLine($"Result is {await Numbers.DivideAsync(45,5)}");
}
catch (Exception ex)
{
    Console.WriteLine($"Error occurred: {ex.Message}");
}

Console.WriteLine("Please Click Any Key To Carry On Seeing the Code Examples");
Console.ReadLine();

(int, int) point1 = (0, 0);
(int, int) point2 = (5, 5);
(int, int) point3 = (-5, 5);
(int, int) point4 = (-5, -5);
(int, int) point5 = (5, -5);
(int, int) point6 = (3, 0);
(int, int) point7 = (0, -2);

var tupleProcessor = new TupleProcessor();
Console.WriteLine($"Point {point1}: {tupleProcessor.ProcessTuple(point1)}");
Console.WriteLine($"Point {point2}: {tupleProcessor.ProcessTuple(point2)}");
Console.WriteLine($"Point {point3}: {tupleProcessor.ProcessTuple(point3)}");
Console.WriteLine($"Point {point4}: {tupleProcessor.ProcessTuple(point4)}");
Console.WriteLine($"Point {point5}: {tupleProcessor.ProcessTuple(point5)}");
Console.WriteLine($"Point {point6}: {tupleProcessor.ProcessTuple(point6)}");
Console.WriteLine($"Point {point7}: {tupleProcessor.ProcessTuple(point7)}");
Console.WriteLine("Please Click Any Key To Carry On Seeing the Code Examples");
Console.ReadLine();

Console.WriteLine($"Score {95}: {PersonMatcher.EvaluateGrade(95)}");
Console.WriteLine($"Score {85}: {PersonMatcher.EvaluateGrade(85)}");
Console.WriteLine($"Score {75}: {PersonMatcher.EvaluateGrade(75)}");
Console.WriteLine($"Score {65}: {PersonMatcher.EvaluateGrade(65)}");
Console.WriteLine($"Score {55}: {PersonMatcher.EvaluateGrade(55)}");

try
{
    Console.WriteLine($"Score {105}: {PersonMatcher.EvaluateGrade(105)}");
}
catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine(ex.Message);
}
Console.WriteLine("Please Click Any Key To Carry On Seeing the Code Examples");
Console.ReadLine();