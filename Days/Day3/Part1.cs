using System.Text.RegularExpressions;

namespace AdventOfCode.Days.Day3;

public class Part1 : IDayPart
{
    public int Solve()
    {
        var text = Common.ReadInput();
        var matches = Regex.Matches(text, @"mul\(\d{1,3},\d{1,3}\)");

        var total = 0;
        foreach (Match match in matches)
        {
            var numbers = Regex
                .Matches(match.Value, @"\d{1,3}")
                .Select(n => int.Parse(n.Value))
                .ToArray();
            total += numbers[0] * numbers[1];
        }
        return total;
    }
}