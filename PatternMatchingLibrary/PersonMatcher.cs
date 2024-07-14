using PatternMatchingLibrary.Models;

namespace PatternMatchingLibrary;

public static class PersonMatcher
{
    public static void MatchPerson(Person person)
    {
        switch (person)
        {
            case Person("Lisa", "Smith"):
                Console.WriteLine("Welcome, Lisa Smith!");
                break;
            case Person(var firstName, var lastName):
                Console.WriteLine($"Hello, {firstName} {lastName}");
                break;
            default:
                Console.WriteLine("Unknown person");
                break;
        }
    }

    public static string EvaluatePerson((string firstName, string lastName) person)
    {
        return person switch
        {
            ("Admin", "Doe") => "Welcome, Mr. Smith!",
            (var first, var last) when first.Length + last.Length > 10 => $"Long name: {first} {last}",
            _ => "Unknown person"
        };
    }

    public static IEnumerable<Person> GetPersonsStartingWithA()
    {
        var persons = new List<Person>
        {
            new Person("Ziggy","Rafiq"),
            new Person("Andrew","Smith"),
            new Person("Alice", "Joes")
        };
        return from person in persons where person.FirstName.StartsWith("A") select person;
    }

    public static string EvaluateGrade(int score)
    {
        string grade = score switch
        {
            >= 90 => "A",
            >= 80 and < 90 => "B",
            >= 70 and < 80 => "C",
            >= 60 and < 70 => "D",
            < 60 => "F"
        };
        return grade;
    }
}
