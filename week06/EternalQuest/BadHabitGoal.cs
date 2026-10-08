using System;

public class BadHabitGoal : Goal
{
    public BadHabitGoal(string name, string description, int penaltyPoints) : base(name, description, penaltyPoints)
    {
    }

    public override int RecordEvent()
    {
        // Returns negative points to deduct score when bad habit occurs
        return -_points;
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetDetailsString()
    {
        return $"[!] {_shortName} ({_description}) -- Penalty: {_points} pts per occurrence";
    }

    public override string GetStringRepresentation()
    {
        return $"BadHabitGoal:{_shortName},{_description},{_points}";
    }
}