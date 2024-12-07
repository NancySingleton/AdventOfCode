using AdventOfCode.Days;

while (true)
{
    SolveRequestedDayPart();
}

void SolveRequestedDayPart()
{
    Console.WriteLine("Which day would you like to solve?");
    var dayNumber = Console.ReadLine();

    Console.WriteLine($"Which part of day {dayNumber}?");
    var partNumber = Console.ReadLine();

    try
    {
        var dayPart = DayPartFactory.ParseDayPart(dayNumber, partNumber);
        Console.WriteLine(dayPart.Solve());
    }
    catch (InvalidDayPartException e)
    {
        Console.WriteLine(e.Message);
    }
}