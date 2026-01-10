using System;

class Program
{
    static void Main(string[] args)
    {
        
        // Ask for percentage
        Console.Write("Please provide your percentage in the class: ");
        int percent = int.Parse(Console.ReadLine());
        string letter = " ";
        string sign = " ";
        
        // Grade letter
        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }
        
        // Grade sign (+ OR -)
        if ((percent%10) >= 7)
        {
            if (letter == "A" || letter == "F")
            {
                sign = " ";
            }
            else
            {
                sign = "+";
            }
        
        }
        else if ((percent%10) < 3)
        {
            if (letter == "F")
            {
                sign = " ";
            }
            else
            {
                sign = "-";
            }
        }
        else
        {
            sign = " ";
        }
        
        // Output
        Console.WriteLine($"Your grade: {letter}{sign}");
        
        if (percent >= 70)
        {
            Console.WriteLine("You passed the class! Congratulations!");
        }
        else
        {
            Console.WriteLine("You did not pass the class. Take it again to get a better grade!");
        }
    }
}