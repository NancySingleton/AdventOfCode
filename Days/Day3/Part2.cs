using System.Text.RegularExpressions;

namespace AdventOfCode.Days.Day3;

public class Part2 : IDayPart
{
    public int Solve()
    {
        var text = Common.ReadInput();
        var total = 0;

        Regex.ValueSplitEnumerator ranges = Common.GetInstructionMatches(text);

        var lastInstructionIndex = 0;
        foreach (var range in ranges)
        {
            var lastInstructionIsDo = Do(text, lastInstructionIndex);
            lastInstructionIndex = range.End.Value;
            
            if (!lastInstructionIsDo) continue;

            var substring = text.Substring(range.Start.Value, range.End.Value - range.Start.Value);
            total += Part1.Calculate(substring);
        }

        return total;
    }

    private static bool Do(string text, int startIndex)
    {
        return startIndex == 0 || text.Substring(startIndex, 7) != "don't()";
    }
}