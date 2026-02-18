using System;

public class StationaryBike : Activity
{
    private double _speed;

    public StationaryBike(string date, double length, double speed) : base(date, length)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return _speed * (GetLength() / 60.0);
    }
    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetPace()
    {
        return 60.0 / _speed;
    }
    public override string GetActivityName()
    {
        return "Stationary Bicyle";
    }
}