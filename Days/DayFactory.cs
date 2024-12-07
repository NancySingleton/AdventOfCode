namespace AdventOfCode.Days;

public abstract class DayFactory
{
    public static IDay ParseDay(string? dayNumber)
    {
        if (dayNumber == null) throw new InvalidDayNumberException();
        
        var type = Type.GetType($"AdventOfCode.Days.Day{dayNumber}.Day{dayNumber}");
        if (type == null) throw new InvalidDayNumberException(dayNumber);
        
        var instance = Activator.CreateInstance(type);
        if (instance is not IDay day) throw new InvalidDayNumberException(dayNumber);

        return day;
    }
}