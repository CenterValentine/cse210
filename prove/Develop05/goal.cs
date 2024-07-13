using System;


public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;
    public Goal(string name, string description, int points = 0)
    {
        _name = name;
        _description = description;
        _points = points;
    }
    public virtual string GetDetailsString()
    { return $"Name: {_name}, Description: {_description}, Points: {_points}"; }
    public virtual string GetStringRepresentation()
    { return $"Name: {_name}| Description: {_description}| Points: {_points}"; }
    public abstract void RecordEvent();
    public abstract bool IsComplete();
}


