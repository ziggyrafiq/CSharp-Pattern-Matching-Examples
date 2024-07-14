namespace PatternMatchingLibrary;
public static class UserInputValidation
{
    public static string ValidateUserInput(string input)
    {
        string validationMessage = input switch
        {
            null or "" => "Input cannot be null or empty",
            { Length: > 20 } => "Input length exceeds 20 characters",
            "admin" or "administrator" => "Reserved username",
            _ => "Input is valid"
        };
        return validationMessage;
    }
}
