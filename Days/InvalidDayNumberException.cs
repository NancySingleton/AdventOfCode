namespace AdventOfCode.Days;

public class InvalidDayNumberException : Exception
{
    public InvalidDayNumberException() : base("Please enter a valid day number.")
    {
    }
    
    public InvalidDayNumberException(string dayNumber) : base($"Day {dayNumber} has not been solved yet!")
    {
    }
}
