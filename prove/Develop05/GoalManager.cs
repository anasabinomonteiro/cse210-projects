using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }

    public void ListGoalsName()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("Enter the type of goal:");
        Console.WriteLine("1. Simple goal");
        Console.WriteLine("2. Eternal goal");
        Console.WriteLine("3. CheckList Goal");
        int typeChoice;
        if (!int.TryParse(Console.ReadLine(), out typeChoice) || typeChoice < 1 || typeChoice > 3)
        {
            Console.WriteLine("Invalid choice. Please enter 1,2, or 3.");
            return;
        }

        Console.WriteLine("Enter the name of the goal: ");
        string shortName = Console.ReadLine();

        Console.WriteLine("Enter a shor description of the goal: ");
        string description = Console.ReadLine();

        Console.WriteLine("Enter the points for the goal: ");
        int points;
        if (!int.TryParse(Console.ReadLine(), out points))
        {
            Console.WriteLine("Enter a valid number please.");
            return;
        }

        switch (typeChoice)
        {
            case 1:
                _goals.Add(new SimpleGoal(shortName, description, points));
                break;
            case 2:
                _goals.Add(new EternalGoal(shortName, description, points));
                break;
            case 3:
                Console.WriteLine("Enter the target number of times: ");
                int target;
                if (!int.TryParse(Console.ReadLine(), out target))
                {
                    Console.WriteLine("Please, enter a valid number.");
                    return;
                }

                Console.WriteLine("Enter the bonus points: ");
                int bonus;
                if (!int.TryParse(Console.ReadLine(), out bonus))
                {
                    Console.WriteLine("Please enter a valid number for bonus.");
                    return;
                }

                _goals.Add(new CheckListGoal(shortName, description, points, target, bonus));
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                break;
        }
    }
    public void RecordEvent()
    {
        Console.WriteLine("Select a goal to record an event:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }

        int choice = int.Parse(Console.ReadLine()) - 1;

        if (choice >= 0 && choice < _goals.Count)
        {
            _goals[choice].RecordEvent();
            _score += _goals[choice].GetPoints();

            if (_goals[choice] is CheckListGoal checkListGoal)
            {
                if (checkListGoal.IsComplete())
                {
                    _score += checkListGoal.GetBonus();
                }
            }
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }
    }

    public void SaveGoals()
    {
        Console.WriteLine("What is the filename to save?");
        string filename = Console.ReadLine();

        using (StreamWriter file = new StreamWriter(filename))
        {
            foreach (var goal in _goals)
            {
                file.WriteLine(goal.GetStringRepresentation());
            }
            file.WriteLine($"Score|{_score}");
        }
    }
    public void LoadGoals()
    {
        Console.WriteLine("What is the filename to load?");
        string filename = Console.ReadLine();

        if (File.Exists(filename))
        {
            using (StreamReader file = new StreamReader(filename))
            {
                _goals.Clear();
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');
                    if (parts[0] == "SimpleGoal")
                    {
                        SimpleGoal goal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
                        if (bool.Parse(parts[4]))
                        {
                            goal.RecordEvent();
                        }
                        _goals.Add(goal);
                    }
                    else if (parts[0] == "EternalGoal")
                    {
                        EternalGoal goal = new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));
                        _goals.Add(goal);
                    }
                    else if (parts[0] == "CheckListGoal")
                    {
                        CheckListGoal goal = new CheckListGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[5]), int.Parse(parts[6]));
                        for (int i = 0; i < int.Parse(parts[4]); i++)
                        {
                            goal.RecordEvent();
                        }
                        _goals.Add(goal);
                    }
                    else if (parts[0] == "Score")
                    {
                        _score = int.Parse(parts[1]);
                    }
                }
            }
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}
