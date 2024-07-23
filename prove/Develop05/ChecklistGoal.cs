using System;

public class ChecklistGoal : Goal
{
    int _amountCompleted;
    int _targetAmount;
    int _bonus;
    public ChecklistGoal(string name, string description, int points, int targetAmount, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _targetAmount = targetAmount;
        _bonus = bonus;
    }

    public ChecklistGoal(string name, string description, int points, int amountCompleted, int targetAmount, int bonus) : base(name, description, points)
    {
        _amountCompleted = amountCompleted;
        _targetAmount = targetAmount;
        _bonus = bonus;
    }
    public override string GetDetailsString()
    { return $"{StatusBox()} Name: {_name}, Description: {_description}, Points: {_points}, Amount Completed: {_amountCompleted}, Target Amount: {_targetAmount}, Bonus Points: {_bonus}"; }
    public override string GetStringRepresentation()
    { return $"{StatusBox()}| Name: {_name}| Description: {_description}| Points: {_points}| Amount Completed: {_amountCompleted}| Target Amount: {_targetAmount}| Bonus Points: {_bonus}"; }
    public override double RecordEvent()
    {
        _amountCompleted = _amountCompleted + 1;

        if (IsComplete())
        {
            Console.WriteLine($"\nNice job! You've completed this goal and earned {_bonus} bonus points!\n");
            return _points + _bonus;
        }
        else
        {
            Console.WriteLine($"\nNice job! You've made progress ({_amountCompleted} out of {_targetAmount}) on your {_name} goal. Here's {_points} points.  Keep it up!\n");
        }

        return _points;
    }
    public override bool IsComplete()
    {
        if (_amountCompleted == _targetAmount)
        {
            return true;
        }
        else
        { return false; }
    }
}