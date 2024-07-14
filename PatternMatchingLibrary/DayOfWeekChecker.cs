namespace PatternMatchingLibrary;
public class DayOfWeekChecker
{
    public void CheckDay(DayOfWeek dayOfWeek)
    {
        switch (dayOfWeek)
        {
            case DayOfWeek.Monday:
                Console.WriteLine("Today is Monday");
                break;
            case DayOfWeek.Friday:
                Console.WriteLine("Today is Friday");
                break;
            default:
                Console.WriteLine("It's neither Monday nor Friday");
                break;
        }
    }

    public string GetDayOfWeek(DayOfWeek dayOfWeek)
    {
        string message = dayOfWeek switch
        {
            DayOfWeek.Monday => "It's Monday!",
            DayOfWeek.Friday => "It's Friday!",
            _ => "It's another day."
        };

        return message;
    }
}
