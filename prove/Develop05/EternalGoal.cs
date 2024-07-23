using System;
public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points) { }

    public override double RecordEvent()
    {
        Console.WriteLine($"Nice job! You've made progress on your {_name} goal. Here's {_points} points.  Keep it up!");

        return _points;
    }
    public override bool IsComplete()
    { return false; }

}