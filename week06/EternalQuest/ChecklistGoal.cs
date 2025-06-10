using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
        if (_amountCompleted >= _target)
        {
            _points += _bonus;
        }
    }

    public override bool IsComplete() => _amountCompleted >= _target;
    public override string GetDetailsString() => $"{base.GetDetailsString()} -- Completed {_amountCompleted}/{_target}";
    public override string GetStringRepresentation() => $"ChecklistGoal:{_name},{_description},{_points},{_bonus},{_target},{_amountCompleted}";
}