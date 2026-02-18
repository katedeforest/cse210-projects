using System;

public class LapPool : Activity
{
    private double _numLaps;

    public LapPool(string date, double length, double numLaps) : base(date, length)
    {
        _numLaps = numLaps;
    }

    public override double GetDistance()
    {
        return _numLaps * 50 / 1000.0 * 0.62;
    }
    public override double GetSpeed()
    {
        return (GetDistance() / GetLength()) * 60;
    }
    public override double GetPace()
    {
        return GetLength() / GetDistance();
    }
    public override string GetActivityName()
    {
        return "Lap Pool";
    }
}