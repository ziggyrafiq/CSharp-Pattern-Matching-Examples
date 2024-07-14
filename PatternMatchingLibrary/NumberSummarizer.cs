namespace PatternMatchingLibrary;

public static class NumberSummarizer
{    public static int SumNumbers(object obj)
    {
        switch (obj)
        {
            case int num:
                return num;
            case IEnumerable<int> numbers:
                return numbers.Sum();
            case IEnumerable<object> objects:
                return objects.OfType<int>().Sum(o => SumNumbers(o));
            default:
                return 0;
        }
    }

    public static string EvaluateNumber(int number)
    {
        string result = number switch
        {
            >= 1 and <= 10 => "Number is between 1 and 10",
            < 0 or > 100 => "Number is less than 0 or greater than 100",
            not 42 => "Number is not 42",
            _ => "Number doesn't match any specified condition"
        };
        return result;
    }

}
