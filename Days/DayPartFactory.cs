namespace AdventOfCode.Days;

public abstract class DayPartFactory
{
    public static IDayPart ParseDayPart(string? dayNumber, string? partNumber)
    {
        if (dayNumber == null || partNumber == null) throw new InvalidDayPartException();
        
        var type = Type.GetType($"AdventOfCode.Days.Day{dayNumber}.Part{partNumber}");
        if (type == null) throw new InvalidDayPartException(dayNumber, partNumber);
        
        var instance = Activator.CreateInstance(type);
        if (instance is not IDayPart dayPart) throw new InvalidDayPartException(dayNumber, partNumber);

        return dayPart;
    }
}