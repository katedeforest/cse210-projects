using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {}

    public void Run()
    {
        base.DisplayStartingMessage();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(base._duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("\nBreathe in...");
            base.ShowCountDown(4);
            Console.WriteLine("Breathe out...");
            base.ShowCountDown(6);
        }

        base.DisplayEndingMessage();
    }
}