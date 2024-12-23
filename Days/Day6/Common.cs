namespace AdventOfCode.Days.Day6;

public abstract class Common
{
    public static char[][] ReadInput()
    {
        const string inputFile = "../../../Days/Day6/input.csv";
        var lines = File.ReadAllLines(inputFile);
        return lines.Select(line => line.ToCharArray()).ToArray();
    }
}