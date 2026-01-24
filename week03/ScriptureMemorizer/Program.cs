using System;

class Program
{
    static void Main(string[] args)
    {
        // Store a scripture, including both the reference (for example "John 3:16") and the text of the scripture.
        // Accommodate scriptures with multiple verses, such as "Proverbs 3:5-6".
        // Clear the console screen and display the complete scripture, including the reference and the text.
        // Prompt the user to press the enter key or type quit. // If the user types quit, the program should end.
        // If the user presses the enter key (without typing quit), the program should hide a few random words in the scripture, clear the console screen, and display the scripture again. (Hiding a word means that the word should be replace by underscores (_) and the number of underscores should match the number of letters in that word.)
        // The program should continue prompting the user and hiding more words until all words in the scripture are hidden.
        // When all words in the scripture are hidden, the program should end. (The final display of the scripture should show the scripture with all words hidden.)
        // When selecting the random words to hide, for the core requirements, you can select any word at random, even if the word was already hidden. (As a stretch challenge, try to randomly select from only those words that are not already hidden.)

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