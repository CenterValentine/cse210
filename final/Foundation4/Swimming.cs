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
        return _numberOfLaps * 50 / 1000 * 0.62;
    }
    public override double Pace()
    {
        return _numberOfLaps;
    }

    public override string GetSummary()
    {
        return $"{_date} Swimming ({_length.ToString()} min)- Distance {Distance()} miles. Speed {Speed().ToString()} mph, Pace: {Pace().ToString()} min per mile";
    }
}