using System;

public class Swimming : Activity
{
    protected int _numberOfLaps;


    public Swimming(string date, double length, int numberOfLaps) : base(date, length)
    {
        _numberOfLaps = numberOfLaps;
    }

    public override double Distance()
    {
        // Console.WriteLine($"Distance Swimming: {_numberOfLaps * 50 / (1000 * 0.62)}");
        // round to 2 decimal places
        return Math.Round(_numberOfLaps * 50 * 0.00062137, 4);
    }

    public override double Pace()
    {
        // Console.WriteLine($"Pace Swimming: {60 / Distance()}");
        return Math.Round(_length / Distance(), 3);
    }

    public override string GetSummary()
    {
        return $"{_date}: Swam for {_length.ToString()} min at a distance of {Distance()} miles. Speed: {Speed().ToString()} mph. Pace: {Pace().ToString()} min per mile.";
    }
}