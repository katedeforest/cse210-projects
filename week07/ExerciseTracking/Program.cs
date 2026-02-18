using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<Activity> _activities = new List<Activity>();

        DateTime currentDate = DateTime.Now;
        string formattedDate = currentDate.ToString("dd MMM yyyy");

        Running running = new Running(formattedDate, 30, 3);
        _activities.Add(running);
        StationaryBike stationaryBike = new StationaryBike(formattedDate, 30, 4.8);
        _activities.Add(stationaryBike);
        LapPool lapPool = new LapPool(formattedDate, 20, 10);
        _activities.Add(lapPool);

        foreach (Activity activity in _activities)
        {
            Console.WriteLine(activity.GetSummary());
        }


    }
}