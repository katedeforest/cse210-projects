using System;

public class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public virtual int RecordEvent()
    {
        return 0;
    }
    public virtual bool IsComplete()
    {
        return false;
    }
    public virtual string GetShortName()
    {
        return _shortName;
    }
    public virtual string GetDetailsString()
    {
        return $"{_shortName} ({_description})";
    }
    public virtual string GetStringRepresentation()
    {
        return $"{_shortName},{_description},{_points}";
    }
}