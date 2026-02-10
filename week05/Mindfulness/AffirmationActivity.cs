using System;
using System.Collections.Generic;

public class AffirmationActivity : Activity
{
    private List<string> _affirmations = new List<string> {"I am safe in this moment.", "I don’t need to solve everything right now.", "I can move slowly and still move forward.", "My anxiety does not define my capability.", "I have handled hard things before — I can handle this too.", "It’s okay to take up space, even when I feel unsure.", "I trust myself to respond when the time comes.", "My worth is steady, even when my emotions are not.", "I am allowed to be both healing and powerful at the same time.", "I am becoming more calm and confident every day."};

    public AffirmationActivity() : base("Affirmation Activity", "This activity will help you soothe anxiety and build confidence by pondering and repeating affirmations.")
    {}

    public void Run()
    {
        base.DisplayStartingMessage();

        Console.WriteLine("Repeat each affirmation either in your head out loud or in your mind.");
        Console.WriteLine("Keep repeating until the next affirmation appears or the program ends.\n");
        base.ShowCountDown(10);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(base._duration);

        List<string> shuffledAffirmations = ShuffleAffirmations(_affirmations);

        while (DateTime.Now < endTime)
        {
            foreach (string affirmation in shuffledAffirmations)
            {
                if (DateTime.Now >= endTime)
                {
                    break;
                }
                
                Console.WriteLine($"--- {affirmation} ---\n");
                base.ShowSpinner(15);
            }
        }

        base.DisplayEndingMessage();
    }
    public List<string> ShuffleAffirmations(List<string> affirmations)
    {
        List<string> shuffled = new List<string>(affirmations);

        Random random = new Random();

        for (int i = shuffled.Count - 1; i > 0; i--)
        {
            int j = random.Next(i + 1);
            (shuffled[i], shuffled[j]) = (shuffled[j], shuffled[i]);
        }

        return shuffled;
    }
}