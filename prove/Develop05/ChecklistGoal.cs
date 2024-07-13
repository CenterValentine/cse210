using System;

public class ChecklistGoal : Goal
{
    int _amountCompleted;
    int _targetAmount;
    int _bonus;
    public ChecklistGoal(string name, string description, int points, int targetAmount, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        targetAmount = _targetAmount;
        bonus = _bonus;
    }
    public override string GetDetailsString()
    { return $"Name: {_name}, Description: {_description}, Points: {_points}, Amount Completed: {_amountCompleted}, Target Amount: {_targetAmount}, Bonus Points: {_bonus}"; }
    public override string GetStringRepresentation()
    { return $"Name: {_name}| Description: {_description}| Points: {_points}| Amount Completed: {_amountCompleted}| Target Amount: {_targetAmount}| Bonus Points: {_bonus}"; }
    public override void RecordEvent()
    { _amountCompleted = _amountCompleted + 1; }
    public override bool IsComplete()
    {
        if (_amountCompleted == _targetAmount)
        {
            _points = _points + _bonus;
            return true;
        }
        else
        { return false; }
    }
}