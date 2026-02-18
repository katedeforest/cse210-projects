using System;

public abstract class Activity
{
    private string _date;
    private double _length;

    public Activity(string date, double length)
    {
        _date = date;
        _length = length;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public abstract string GetActivityName();
    public string GetSummary()
    {
        return $"{_date} {GetActivityName()} ({_length:0} min): Distance: {GetDistance():0.0} miles, Speed {GetSpeed():0.0} mph, Pace {GetPace():0.0} min per mile";
    }
    public double GetLength()
    {
        return _length;
    }
}