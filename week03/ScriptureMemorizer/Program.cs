using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string text = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
        Scripture scripture = new Scripture(reference, text);

        string input = "keep going";
        while (input.ToLower() != "quit")
        {
            // Clear the console screen and display the complete scripture, including the reference and the text.
            Console.Clear();
            Console.WriteLine($"{scripture.GetDisplayText()}");

            if (scripture.IsCompletelyHidden())
            {
                break;
            }

            // Prompt the user to press the enter key or type quit.
            Console.WriteLine("");
            Console.Write("Press the enter key to hide more words or type 'quit' to quit the program: ");
            input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }
            
            scripture.HideRandomWords(4);

        }
    }
}