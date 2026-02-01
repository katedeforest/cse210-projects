using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Assignment assignment = new Assignment("Miles Morales", "English");
        string summary1 = assignment.GetSummary();
        Console.WriteLine($"{summary1}");

        Console.WriteLine("");

        MathAssignment mathAssignment = new MathAssignment("Peter Parker", "Science", "7.3", "8-19");
        string summary2 = mathAssignment.GetSummary();
        string homeworkList = mathAssignment.GetHomeworkList();
        Console.WriteLine($"{summary2}\n{homeworkList}");

        Console.WriteLine("");

        WritingAssignment writingAssignment = new WritingAssignment("Gwen Stacy", "English", "The Spidermans");
        string summary3 = writingAssignment.GetSummary();
        string writingInformation = writingAssignment.GetWritingInformation();
        Console.WriteLine($"{summary3}\n{writingInformation}");
    }
}