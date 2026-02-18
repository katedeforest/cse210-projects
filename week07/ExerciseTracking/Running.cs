using System;

public class Running : Activity
{
    private double _distance;

    public Running(string date, double length, double distance) : base(date, length)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        return (_distance / base.GetLength()) * 60.0;
    }
    public override double GetPace()
    {
        return base.GetLength() / _distance;
    }
    public override string GetActivityName()
    {
        return "Running";
    }
}