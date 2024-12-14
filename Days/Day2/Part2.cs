namespace AdventOfCode.Days.Day2;

public class Part2 : IDayPart
{
    public int Solve()
    {
        var reports = Common.ReadInput();
        return reports.Count(ReportIsSafeWithDampener);
    }

    private static bool ReportIsSafeWithDampener(List<int> report)
    {
        if (Common.ReportIsSafe(report)) return true;

        return report
            .Select((a, i) => report
                .Where((b, index) => index != i)
                .ToList())
            .Any(Common.ReportIsSafe);
    }
}