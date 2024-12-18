using System.Text.RegularExpressions;

namespace AdventOfCode.Days.Day3;

public abstract class Common
{
    private const string MulRegex = @"mul\(\d{1,3},\d{1,3}\)";
    private const string NumberRegex = @"\d{1,3}";

    public static string ReadInput()
    {
        const string inputFile = "../../../Days/Day3/input.csv";
        return File.ReadAllText(inputFile);
    }

    public static MatchCollection GetMulMatches(string text)
    {
        return Regex.Matches(text, MulRegex);
    }

    public static MatchCollection GetNumberMatches(string text)
    {
        return Regex.Matches(text, NumberRegex);
    }
}