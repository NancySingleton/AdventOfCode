namespace AdventOfCode.Days.Day4;

public abstract class Common
{
    public static string[] ReadInput()
    {
        const string inputFile = "../../../Days/Day4/test_input.csv";
        var lines = File.ReadAllLines(inputFile);
        return lines;
    }
}