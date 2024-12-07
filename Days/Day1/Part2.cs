namespace AdventOfCode.Days.Day1;

public class Part2 : IDayPart
{
    public int Solve()
    {
        var (list1, list2) = Common.ReadInput();

        var crossJoin = from lhs in list1 from rhs in list2 where lhs == rhs select lhs;
        return crossJoin.Sum();
    }
}