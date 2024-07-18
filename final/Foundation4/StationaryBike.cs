using System;

public class StationaryBike : Activity
{
    protected double _speed;

    public StationaryBike(string date, double length, double speed) : base(date, length)
    {
        _speed = speed;
    }

    public override double Speed()
    {
        return _speed;
    }

    public override string GetSummary()
    {
        return $"{_date} Biking ({_length} min)- Distance {Distance().ToString()} miles, Speed {Speed().ToString()} mph, Pace: {Pace().ToString()} min per mile"; ;
    }


}