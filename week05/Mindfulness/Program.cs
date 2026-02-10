using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfulness Project.");
        bool quitProgram = false;
        string userInput;

        while (quitProgram == false)
        {
            Console.Clear();

            Console.WriteLine("Activity Menu:\n1) Breathing Activity\n2) Reflection Activity\n3) Listing Activity\n4) Affirmation Activity\n5) Quit");
            Console.Write("Select a choice from the menu: ");
            userInput = Console.ReadLine();

            if (userInput == "1" || userInput.ToLower() == "breathing activity")
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run();
            }
            else if (userInput == "2" || userInput.ToLower() == "reflection activity")
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.Run();
            }
            else if (userInput == "3" || userInput.ToLower() == "listing activity")
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.Run();
            }
            else if (userInput == "4" || userInput.ToLower() == "affirmation activity")
            {
                AffirmationActivity affirmationActivity = new AffirmationActivity();
                affirmationActivity.Run();
            }
            else if (userInput == "5" || userInput.ToLower() == "quit")
            {
                quitProgram = true;
            }
            else
            {
                // restart do-while loop if an invalid value is entered
                Console.WriteLine("Invalid selection. Please try again.");
            }

        }
    }
}