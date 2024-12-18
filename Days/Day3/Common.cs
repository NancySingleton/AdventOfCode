namespace AdventOfCode.Days.Day3;

public abstract class Common
{
    public static string[] ReadInput()
    {
        const string inputFile = "../../../Days/Day3/test_input.csv";
        var lines = File.ReadAllLines(inputFile);
        return lines;
    }
}