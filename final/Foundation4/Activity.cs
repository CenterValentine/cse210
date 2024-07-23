using System;

public abstract class Activity
{
    protected string _date;
    protected double _length;

    // List<Activity> _activities;

    public Activity(string date, double length)
    {
        _date = date;
        _length = length;
    }
    public virtual double Distance()
    {
        // Console.WriteLine($"Distance Base: {Speed() * _length}");
        return _length * (Speed()/60);
    }
    public virtual double Speed()
    {
        // Console.WriteLine($"Speed Base: {Pace()}");
        return Math.Round(60 / Pace(), 2);
    }
    public virtual double Pace()
    {
        // Console.WriteLine("Pace Base");
        return _length / Distance();
    }
    public abstract string GetSummary();
}