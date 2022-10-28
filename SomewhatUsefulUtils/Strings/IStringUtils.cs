namespace SomewhatUsefulUtils.Strings;

public interface IStringUtils
{
    string ReverseString(string input);
}

public class StringUtils : IStringUtils
{
    public string ReverseString(string input)
    {
        var charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}