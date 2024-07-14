namespace PatternMatchingLibrary
{
    public class DataAnalyzer
    {
        public string AnalyzeData(IEnumerable<object> data)
        {
            string result = data switch
            {
                null => "Data is null",
                object[] array when array.Length == 0 => "Empty array",
                List<int> list when list.Count > 10 => $"List of integers with more than 10 elements",
                List<string> list => $"List of strings with {list.Count} elements",
                _ => "Other collection type"
            };
            return result;
        }
    }

}
