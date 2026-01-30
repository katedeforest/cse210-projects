using System;

class Program
{
    static void Main(string[] args)
    {
        ScriptureGenerator generator = new ScriptureGenerator();
        Scripture scripture = generator.GetRandomScripture();

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