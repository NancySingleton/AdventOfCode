namespace AdventOfCode.Days.Day3;

public abstract class Common
{
    public static string ReadInput()
    {
        const string inputFile = "../../../Days/Day3/input.csv";
        return File.ReadAllText(inputFile);
    }
}