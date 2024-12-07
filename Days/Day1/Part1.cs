namespace AdventOfCode.Days.Day1;

public class Part1 : IDayPart
{
    public int Solve()
    {
        var (list1, list2) = Common.ReadInput();
        list1.Sort();
        list2.Sort();

        return list1.Zip(list2, (x, y) => Math.Abs(x - y)).Sum();
    }
}