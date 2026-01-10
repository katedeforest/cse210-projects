using System;

class Program
{
    static void Main(string[] args)
    {
        string keep_playing = "";

        do 
        {
            // User specifies the number
            // Console.Write("What is the magic number? ");
            // int magic_num = int.Parse(Console.ReadLine());

            //Generate a random number but don't show it to the user
            Random randomGenerator = new Random();
            int magic_num = randomGenerator.Next(1, 101);

            int guess_count = 0;
            int guess_num = 0;

            while (guess_num != magic_num)
            {
                Console.Write("What is your guess? ");
                guess_num = int.Parse(Console.ReadLine());
                guess_count += 1;

                if (guess_num < magic_num)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess_num > magic_num)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            }

            if (guess_count == 1)
            {
                Console.WriteLine($"It took you {guess_count} guess.");
            }
            else
            {
                Console.WriteLine($"It took you {guess_count} guesses.");
            }

            Console.Write("Play again? (yes/no) ");
            keep_playing = Console.ReadLine();

        } while (keep_playing.ToLower() == "yes");

        Console.WriteLine("Thanks for playing!");
    }
}