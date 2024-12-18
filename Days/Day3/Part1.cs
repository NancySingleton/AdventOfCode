using System.Text.RegularExpressions;

namespace AdventOfCode.Days.Day3;

public class Part1 : IDayPart
{
    public int Solve()
    {
        var text = Common.ReadInput();
        var matches = Common.GetMulMatches(text);

        var total = 0;
        foreach (Match match in matches)
        {
            var numbers = Common.GetNumberMatches(match.Value)
                .Select(n => int.Parse(n.Value))
                .ToArray();
            total += numbers[0] * numbers[1];
        }
        return total;
    }
}