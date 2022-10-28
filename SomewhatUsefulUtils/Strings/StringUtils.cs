using System.Globalization;

namespace SomewhatUsefulUtils.Strings;

public class StringUtils : IStringUtils
{
    public string ReverseString(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            throw new ArgumentException($"{nameof(input)} must be a non whitepsace/empty string");
        }

        var charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    public string ToTitleCase(string input, CultureInfo culture)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            throw new ArgumentException($"{nameof(input)} must be a non whitepsace/empty string");
        }

        return culture.TextInfo.ToTitleCase(input);
    }
}