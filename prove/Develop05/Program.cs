using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();

        while (true)
        {
            manager.DisplayPlayerInfo();
            Console.WriteLine("Menu options:");
            Console.WriteLine("1. Create New Goal.");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.WriteLine("Select a choice from the menu: ");

            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Please entre a number netween 1 and 6.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    manager.CreateGoal();
                    break;
                case 2:
                    manager.ListGoalsName();
                    break;
                case 3:
                    manager.SaveGoals();
                    break;
                case 4:
                    manager.LoadGoals();
                    break;
                case 5:
                    manager.RecordEvent();
                    break;
                case 6:
                    return;
                default:
                    Console.WriteLine("Please, enter a number betweeen 1 and 6.");
                    break;
            }
        }
    }
}