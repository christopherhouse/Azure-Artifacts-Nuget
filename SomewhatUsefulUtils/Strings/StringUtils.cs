using System.Globalization;

namespace SomewhatUsefulUtils.Strings;

public class StringUtils : IStringUtils
{
    public string ReverseString(string input)
    {
        var charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    public string ToTitleCase(string input, CultureInfo culture)
    {
        return culture.TextInfo.ToTitleCase(input);
    }
}