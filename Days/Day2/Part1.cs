namespace AdventOfCode.Days.Day2;

public class Part1 : IDayPart
{
    public int Solve()
    {
        var reports = Common.ReadInput();
        return reports.Count(Common.ReportIsSafe);
    }
}