namespace PatternMatchingLibrary;

public static class Numbers
{
    public static int SumNumbers(object obj)
    {
        return obj switch
        {
            int num => num,
            IEnumerable<int> numbers => numbers.Sum(),
            IEnumerable<object> objects => objects.Sum(o => SumNumbers(o)),
            _ => 0
        };
    }

    public static async Task<int> DivideAsync(int numerator, int denominator)
    {
        try
        {
            return await Task.Run(() =>
            {
                if (denominator == 0)
                    throw new DivideByZeroException();

                return numerator / denominator;
            });
        }
        catch (DivideByZeroException)
        {
            return -1;  
        }
    }
}
