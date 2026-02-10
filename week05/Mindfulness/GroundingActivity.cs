using System;
using System.Collections.Generic;

public class GroundingActivity : Activity
{
    // 

    public GroundingActivity() : base("Grounding Activity", "This activity will help you ground yourself in your body and the present moment by having you identify things you can sense with your different senses.")
    {}

    public void Run()
    {
        base.DisplayStartingMessage();

        Console.WriteLine($"List five (5) things you can SEE:");
        PromptUser(5);
        
        Console.WriteLine($"List four (4) things you can FEEL:");
        PromptUser(4);

        Console.WriteLine($"List three (3) things you can HEAR:");
        PromptUser(3);

        Console.WriteLine($"List two (2) things you can SMELL:");
        PromptUser(2);

        Console.WriteLine($"List one (1) thing you can TASTE:");
        PromptUser(1);

        base.DisplayEndingMessage();
    }
    public void PromptUser(int promptNumber)
    {
        for (int i = promptNumber; i > 0; i--)
        {
            Console.Write($"> ");
            Console.ReadLine();
        }
    }
}