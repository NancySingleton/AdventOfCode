namespace AdventOfCode.Days.Template;

public abstract class Common
{
    public static string[] ReadInput()
    {
        const string inputFile = "../../../Days/DayX/input.csv";
        var lines = File.ReadAllLines(inputFile);
        return lines;
    }
}