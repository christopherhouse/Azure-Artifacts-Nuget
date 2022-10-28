using System.Globalization;

namespace SomewhatUsefulUtils.Strings;

public interface IStringUtils
{
    string ReverseString(string input);

    string ToTitleCase(string input, CultureInfo culture);
}