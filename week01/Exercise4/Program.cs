using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbers = new List<int>();
        int new_num = 0;

        // CREATE NUMBER LIST
        do
        {
            Console.Write("Type a number: ");
            new_num = int.Parse(Console.ReadLine());

            if (new_num != 0)
            {
                numbers.Add(new_num);
            }
        } while (new_num != 0);

        // ADD ALL NUMBERS
        int total_sum = 0;
        foreach (int number in numbers)
        {
            total_sum += number;
        }
        Console.WriteLine($"The sum is: {total_sum}");

        // GET AVERAGE OF ALL NUMBERS
        double average = (double) total_sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // GET THE LARGEST NUMBER
        int largest_number = 0;
        foreach (int number in numbers)
        {
            if (number > largest_number)
            {
                largest_number = number;
            }
        }
        Console.WriteLine($"The largest number is: {largest_number}");

        // GET THE SMALLEST POSITIVE NUMBER
        int smallest_number = int.MaxValue;
        foreach (int number in numbers)
        {
            if (number < smallest_number && number > 0)
            {
                smallest_number = number;
            }
        }
        Console.WriteLine($"The smallest positive number is: {smallest_number}");

        // SORT THE LIST OF NUMBERS
        numbers.Sort();
        Console.WriteLine($"The sorted list of numbers is:");
        foreach (int number in numbers)
        {
            Console.WriteLine($"{number}");
        }
    }
}