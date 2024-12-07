namespace AdventOfCode.Days;

public class InvalidDayPartException : Exception
{
    public InvalidDayPartException() : base("Please enter a valid day and part number.")
    {
    }
    
    public InvalidDayPartException(string dayNumber, string partNumber) 
        : base($"Day {dayNumber} Part {partNumber} has not been solved yet!")
    {
    }
}
