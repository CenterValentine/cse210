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
        return Speed() * _length;
    }
    public virtual double Speed()
    {
        return 60 / Pace();
    }
    public virtual double Pace()
    {
        return _length / Distance();
    }
    public abstract string GetSummary();
}