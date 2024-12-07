using AdventOfCode.Days;

while (true)
{
    SolveRequestedDay();
}

void SolveRequestedDay()
{
    Console.WriteLine("Which day would you like to solve?");
    var dayNumber = Console.ReadLine();

    try
    {
        var day = DayFactory.ParseDay(dayNumber);
        Console.WriteLine(day.Solve());
    }
    catch (InvalidDayNumberException e)
    {
        Console.WriteLine(e.Message);
    }
}