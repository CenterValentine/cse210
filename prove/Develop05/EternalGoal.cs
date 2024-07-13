using System;
public class EternalGoal : Goal
{

    public EternalGoal(string name, string description, int points) : base(name, description, points) { }

    public override void RecordEvent()
    { Console.WriteLine($"Nice job! You've made progress on your {_name} goal. Here's {_points} points.  Keep it up!"); }
    public override bool IsComplete()
    { return false; }

}