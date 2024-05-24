using System;

public class EternalGoal : Goal
{
    public EternalGoal(string shortName, string description, int points) : base(shortName, description, points)
    {
    }

    public override void RecordEvent()
    {
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetDetailsString()
    {
        return $"[{"X"}] {_shortName}: {_description} - {_points} points each time.";
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal| {_shortName}|{_description}|{_points}";
    }
}