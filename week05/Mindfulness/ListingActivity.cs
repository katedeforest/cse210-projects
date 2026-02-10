using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string> {"Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"};

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {}

    public void Run()
    {
        base.DisplayStartingMessage();

        Console.WriteLine($"List as many responses as you can to the following prompt:\n --- {GetRandomPrompt()} ---");
        Console.WriteLine($"");
        Console.Write($"You may begin in: ");
        base.ShowCountDown(5);

        List<string> responseList = GetListFromUser();
        if (responseList.Count == 1)
        {
            Console.WriteLine($"You listed {responseList.Count} item!");
        }
        else
        {
            Console.WriteLine($"You listed {responseList.Count} items");
        }

        base.DisplayEndingMessage();
    }
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int selector = random.Next(_prompts.Count);
        string randomPrompt = _prompts[selector];
        return randomPrompt;
    }
    public List<string> GetListFromUser()
    {
        List<string> responseList = new List<string>();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(base._duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            responseList.Add(Console.ReadLine());
        }

        return responseList;
    }
}