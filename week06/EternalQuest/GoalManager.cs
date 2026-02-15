using System;
using System.IO;
using System.Collections.Generic;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager()
    {}

    public void Start()
    {
        string userInput = "";

        while (userInput != "6")
        {
            DisplayPlayerInfo();

            Console.WriteLine("Menu Options:\n1. Create New Goal\n2. List Goals\n3. Save Goals\n4. Load Goals\n5. Record Event\n6. Quit");
            Console.Write("Select a choice from the menu: ");
            userInput = Console.ReadLine();

            if (userInput == "1" || userInput.ToLower() == "create new goal")
            {
                CreateGoal();
            }
            else if (userInput == "2" || userInput.ToLower() == "list goals")
            {
                ListGoalDetails();
            }
            else if (userInput == "3" || userInput.ToLower() == "save goals")
            {
                SaveGoals();
            }
            else if (userInput == "4" || userInput.ToLower() == "load goals")
            {
                
                LoadGoals();
            }
            else if (userInput == "5" || userInput.ToLower() == "record event")
            {
                RecordEvent();
            }
            else if (userInput == "6" || userInput.ToLower() == "quit")
            {
                break;
            }
            else
            {
                Console.WriteLine($"That input is invalid, please try again.");
            }
        }
    }
    public void DisplayPlayerInfo()
    {
        if (_score == 1)
        {
            Console.WriteLine($"\nYou have {_score} point.");
        }
        else
        {
            Console.WriteLine($"\nYou have {_score} points.");
        }

        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine($"Growth Stage: {GetRank()}");
        Console.ResetColor();
        GetRankProgress();
    }
    public void CreateGoal()
    {
        Console.WriteLine($"The types of goals are:\n1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal");
        Console.Write("What kind of goal would you like to create? ");
        string goalType = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string goalName = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string goalDescription = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int goalPoints = int.Parse(Console.ReadLine());

        if (goalType == "1" || goalType.ToLower() == "simple goal")
        {
            SimpleGoal simpleGoal = new SimpleGoal(goalName, goalDescription, goalPoints);
            _goals.Add(simpleGoal);
        }
        else if (goalType == "2" || goalType.ToLower() == "eternal goal")
        {
            EternalGoal eternalGoal = new EternalGoal(goalName, goalDescription, goalPoints);
            _goals.Add(eternalGoal);
        }
        else if (goalType == "3" || goalType.ToLower() == "checklist goal")
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int goalTarget = int.Parse(Console.ReadLine());

            Console.Write("What is the bonus for accomplishing it that many times? ");
            int goalBonus = int.Parse(Console.ReadLine());

            ChecklistGoal checklistGoal = new ChecklistGoal(goalName, goalDescription, goalPoints, goalTarget, goalBonus);
            _goals.Add(checklistGoal);
        }
    }
    public void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetShortName()}");
        }
    }
    public void ListGoalDetails()
    {
        if (_goals.Count > 0)
        {
            foreach (Goal goal in _goals)
            {
                int index = _goals.IndexOf(goal) + 1;
                Console.Write($"{index}. ");

                if (goal.IsComplete())
                {
                    Console.Write("[X] ");
                }
                else
                {
                    Console.Write("[ ] ");
                }

                Console.Write($"{goal.GetDetailsString()}\n");
            }
        }
        else
        {
            Console.WriteLine("You do not have any goals yet.\n");
        }
    }
    public void SaveGoals()
    {
        Console.Write("What is the filename? ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine($"{_score}");
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine($"{goal.GetStringRepresentation()}");
            }
        }
    }
    public void LoadGoals()
    {
        Console.Write("What is the filename? ");
        string fileName = Console.ReadLine();
        string firstLine;

        using (StreamReader reader = new StreamReader(fileName))
        {
            // Read the first line
            firstLine = reader.ReadLine();
            _score = int.Parse(firstLine);

            string subsequentLine; 
            while ((subsequentLine = reader.ReadLine()) != null)
            {
                string[] typeDetailSplit = subsequentLine.Split("«");
                string goalType = typeDetailSplit[0];
                string goalDetails = typeDetailSplit[1];
                string[] details = goalDetails.Split("|");

                string shortName = details[0];
                string description = details[1];
                int points = int.Parse(details[2]);
                
                if (goalType == "Simple Goal")
                {
                    bool isComplete = bool.Parse(details[3]);
                    SimpleGoal simpleGoal = new SimpleGoal(shortName, description, points, isComplete);
                    _goals.Add(simpleGoal);
                }
                else if (goalType == "Eternal Goal")
                {
                    EternalGoal eternalGoal = new EternalGoal(shortName, description, points);
                    _goals.Add(eternalGoal);
                }
                else if (goalType == "Checklist Goal")
                {
                    int bonus = int.Parse(details[3]);
                    int target = int.Parse(details[4]);
                    int amountCompleted = int.Parse(details[5]);
                    ChecklistGoal checklistGoal = new ChecklistGoal(shortName, description, points, bonus, target, amountCompleted);
                    _goals.Add(checklistGoal);
                }
            }
        }
    }
    public void RecordEvent()
    {
        string previousRank = GetRank();

        if (_goals.Count == 0)
        {
            Console.WriteLine("You have no goals yet.");
            return;
        }

        Console.WriteLine("\nYour goals are:");
        ListGoalNames();

        Console.Write("Which goal did you accomplish? ");
        if (!int.TryParse(Console.ReadLine(), out int choice))
        {
            Console.WriteLine("Please enter a number.");
            return;
        }
        int index = choice - 1;
        if (index < 0 || index >= _goals.Count)
        {
            Console.WriteLine("That goal number is not valid.");
            return;
        }
        Goal goalAccomplished = _goals[index];
        
        int pointsEarned = goalAccomplished.RecordEvent();
        _score += pointsEarned;

        if (pointsEarned == 1)
        {
            Console.WriteLine($"Congratulations! You have earned {pointsEarned} point!");
        }
        else
        {
            Console.WriteLine($"Congratulations! You have earned {pointsEarned} points!");
        }

        if (goalAccomplished.IsComplete())
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("🌿🌿 You completed this goal! 🌿🌿");
            Console.ResetColor();
        }

        string newRank = GetRank();

        if (previousRank != newRank)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"You advanced to {newRank}!");
            Console.ResetColor();
        }
    }
    private string GetRank()
    {
        if (_score >= 1000)
            return "Thriving 💐";
        else if (_score >= 500)
            return "Bloom 🌷";
        else if (_score >= 200)
            return "Sprout 🌱";
        else
            return "Seed 🌰";
    }
    private void GetRankProgress()
    {
        int pointsNeeded;
        if (_score < 200)
        {
            pointsNeeded = 200 - _score;
        }
        else if (_score >= 200 && _score < 500)
        {
            pointsNeeded = 500 - _score;
        }
        else if (_score >= 500 && _score < 1000)
        {
            pointsNeeded = 1000 - _score;
        }
        else
        {
            pointsNeeded = 0; // Already at highest rank
        }

        if (pointsNeeded > 0)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"Get {pointsNeeded} more points to advance to the next stage!\n");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("🌳🪴 You are at the highest growth stage! 🪴🌳\n");
            Console.ResetColor();
        }
    }
}