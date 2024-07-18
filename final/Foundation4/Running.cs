using System;

public class Running : Activity
{
    protected double _distance;

    public Running(string date, double length, double distance) : base(date, length)
    {
        _distance = distance;
    }

    public override double Distance()
    {
        return _distance;
    }

    public override string GetSummary()
    {
        return $"{_date} Running ({_length.ToString()} min)- Distance {Distance()} miles. Speed {Speed().ToString()} mph, Pace: {Pace().ToString()} min per mile";
    }

}