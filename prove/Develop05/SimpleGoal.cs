using System;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points, bool isComplete = false) : base(name, description, points)
    { _isComplete = isComplete; }

    public override string GetStringRepresentation()
    { return $"Name: {_name}| Description: {_description}| Points: {_points}| _isComplete: {_isComplete}";}

    public override string GetDetailsString()
    { return $"Name: {_name}, Description: {_description}, Points: {_points}"; }

    public override void RecordEvent()
    {
        _isComplete = true;
        Console.WriteLine($"Nice job! You've completed the goal {_name}. Here's {_points} points.  Keep it up!");
    }

    public override bool IsComplete()
    { return _isComplete; }

}



