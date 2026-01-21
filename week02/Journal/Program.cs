using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");

        Journal journal = new Journal();
        string user_input;

        do
        {
            Console.WriteLine("Please select one of the following choices:\n1. Write\n2. Display\n3. Save\n4. Load\n5. Quit the Program");
            Console.Write("What would you like to do? ");
            user_input = Console.ReadLine();

            if (user_input == "1")
            {
                // display a random prompt with PromptGenerator
                PromptGenerator generator = new PromptGenerator();
                string prompt = generator.GetRandomPrompt();
                Console.WriteLine($"{prompt}");

                // prompt the user to write their response
                Console.Write("> ");
                string response = Console.ReadLine();

                // store prompt and response as an Entry in Journal
                Entry entry = new Entry();

                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();
                entry._date = dateText;

                entry._promptText = prompt;
                entry._entryText = response;

                journal.AddEntry(entry);
            }
            else if (user_input == "2")
            {
                // display all entries from Journal
                journal.DisplayAll();
            }
            else if (user_input == "3")
            {
                // prompt file name to save to
                Console.Write("What is the filename?");
                string filename = Console.ReadLine();

                // check for existing password
                Password password = new Password();
                if (password.checkExist(filename))
                {
                    // ask for the password and verify it
                    Console.Write($"What is the password for {filename}?");
                    string enteredPassword = Console.ReadLine();

                    if (password.verifyPassword(filename, enteredPassword))
                    {
                        // save all Journal Entries to requested file
                        journal.SaveToFile(filename);
                        
                        // give success message
                        Console.WriteLine("PASSWORD CORRECT. Entries saved.");
                    }
                    else
                    {
                        // give fail message
                        Console.WriteLine("PASSWORD INCORRECT");
                    }
                }
                else
                {
                    // ask for a password & create new password
                    Console.Write($"Create a password for {filename}:");
                    string enteredPassword = Console.ReadLine();

                    password.setPassword(enteredPassword);
                }


                
            }
            else if (user_input == "4")
            {
                // prompt file name to load from
                Console.Write("What is the filename?");
                string filename = Console.ReadLine();

                // ask for password
                Console.Write($"What is the password for {filename}?");
                string enteredPassword = Console.ReadLine();

                // verify password
                Password password = new Password();
                if (password.verifyPassword(filename, enteredPassword))
                {
                    // load entries
                    journal.LoadFromFile(filename);
                    
                    // give success message
                    Console.WriteLine("PASSWORD CORRECT. Entries loaded.");
                }
                else
                {
                    // give fail message
                    Console.WriteLine("PASSWORD INCORRECT");
                }
            }
            else if (user_input == "5")
            {
                // exit if statement
                Console.WriteLine("Thanks for writing in your journal. Exiting program.");
                return;
            }
            else
            {
                // restart do-while loop if an invalid value is entered
                Console.WriteLine("Invalid value. Please try again.");
            }
        } while (user_input != "5"); // quit the program if user enters 5
    }
}