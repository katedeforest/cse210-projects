using System;

public class SimpleGoal : Goal
{
    private bool _isComplete = false;

    public SimpleGoal(string name, string description, string points) : base(name, description, points)
    {}

    public virtual void RecordEvent()
    {}
    public virtual bool IsComplete()
    {
        return false;
    }
    public virtual string GetStringRepresentaion()
    {
        return "";
    }
}