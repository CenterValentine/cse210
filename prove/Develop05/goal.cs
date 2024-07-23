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

    protected string StatusBox()
    {
        string statusBox = "[ ]";
        if (IsComplete())
        { statusBox = "[X]"; }
        return statusBox;
    }

    public virtual string GetDetailsString()
    {

        return $"{StatusBox()} Name: {_name}, Description: {_description}, Points: {_points}";
    }
    public virtual string GetStringRepresentation()
    { return $"{StatusBox()}| Name: {_name}| Description: {_description}| Points: {_points}"; }
    public abstract double RecordEvent();
    public abstract bool IsComplete();
}


