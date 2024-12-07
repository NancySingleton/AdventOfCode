namespace AdventOfCode.Days.Day1;

public abstract class Common
{
    public static (List<int>, List<int>) ReadInput()
    {
        const string inputFile = "../../../Days/Day1/input.csv";
        var lines = File.ReadAllLines(inputFile);

        var list1 = new List<int>();
        var list2 = new List<int>();
        
        foreach (var line in lines)
        {
            var numbers = line.Split("   ");
            list1.Add(int.Parse(numbers[0]));
            list2.Add(int.Parse(numbers[1]));
        }
        return (list1, list2);
    }
}