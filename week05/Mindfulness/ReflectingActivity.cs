using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string> {"Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."};
    private List<string> _questions = new List<string> {"Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"};

    public ReflectingActivity() : base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {}

    public void Run()
    {
        base.DisplayStartingMessage();

        DisplayPrompt();
        Console.Write("\nWhen you have something in mind, press enter to continue. ");
        Console.ReadLine();

        Console.WriteLine("\nNow ponder on each of the following questions as they related to this experience.");
        Console.Write($"You may begin in: ");
        base.ShowCountDown(5);
        Console.WriteLine($"");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(base._duration);
        while (DateTime.Now < endTime)
        {
            DisplayQuestions();
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
    public string GetRandomQuestion()
    {
        Random random = new Random();
        int selector = random.Next(_questions.Count);
        string randomQuestion = _questions[selector];
        return randomQuestion;
    }
    public void DisplayPrompt()
    {
        Console.WriteLine($"\nConsider the following prompt:\n\n --- {GetRandomPrompt()} ---");
    }
    public void DisplayQuestions()
    {
        Console.WriteLine($">{GetRandomQuestion()}");
        base.ShowSpinner(10);
    }
}