namespace AdventOfCode.Days.Day2;

public abstract class Common
{
    public static List<List<int>> ReadInput()
    {
        const string inputFile = "../../../Days/Day2/input.csv";
        return File
            .ReadAllLines(inputFile)
            .Select(line => line
                .Split(" ")
                .Select(int.Parse)
                .ToList())
            .ToList();
    }

    public static bool ReportIsSafe(List<int> report)
    {
        if (report.Count < 2) return true;

        var increasing = report[1] >= report[0];
        var diffs = Common.GetDiffs(report);
        return increasing ? diffs.All(Common.SafeIncrease) : diffs.All(Common.SafeDecrease);
    }

    private static IEnumerable<int> GetDiffs(List<int> numbers)
    {
        return numbers
            .Skip(1)
            .Zip(numbers, (current, previous) => current - previous);
    }

    private static bool SafeIncrease(int diff)
    {
        return diff >= 0 && SafeSize(diff);
    }

    private static bool SafeDecrease(int diff)
    {
        return diff <= 0 && SafeSize(diff);
    }

    private static bool SafeSize(int diff)
    {
        return Math.Abs(diff) >= 1 && Math.Abs(diff) <= 3; 
    }
}