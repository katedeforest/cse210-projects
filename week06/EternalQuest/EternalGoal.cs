using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, string points) : base(name, description, points)
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