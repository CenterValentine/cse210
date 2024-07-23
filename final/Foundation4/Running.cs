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
        return $"{_date}: Ran for {_length.ToString()} min at a distance of {Distance()} miles. Speed {Speed().ToString()} mph, Pace: {Pace().ToString()} min per mile";
    }

}