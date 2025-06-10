using System;

class Program
{
    static void Main()
    {
        GoalManager manager = new GoalManager();
        while (true)
        {
            Console.WriteLine("Eternal Quest\n");
            Console.WriteLine($"Score: {manager.GetScore()}\n");
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. Show Goals");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Exit\n");
            Console.Write("Enter an Option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal(manager);
                    break;
                case "2":
                    RecordEvent(manager);
                    break;
                case "3":
                    manager.DisplayGoals();
                    break;
                case "4":
                    manager.SaveGoals("goals.txt");
                    break;
                case "5":
                    manager.LoadGoals("goals.txt");
                    break;
                case "6":
                    return;
            }
        }
    }

    static void CreateGoal(GoalManager manager)
    {
        Console.WriteLine("Goal Types: 1. Simple 2. Eternal 3. Checklist");
        Console.Write("Select Goal Type: ");
        string type = Console.ReadLine();

        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Description: ");
        string desc = Console.ReadLine();
        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        switch (type)
        {
            case "1":
                manager.AddGoal(new SimpleGoal(name, desc, points));
                break;
            case "2":
                manager.AddGoal(new EternalGoal(name, desc, points));
                break;
            case "3":
                Console.Write("Target: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Bonus: ");
                int bonus = int.Parse(Console.ReadLine());
                manager.AddGoal(new ChecklistGoal(name, desc, points, target, bonus));
                break;
        }
    }

    static void RecordEvent(GoalManager manager)
    {
        Console.WriteLine("Select goal to record:");
        manager.DisplayGoals();
        int index = int.Parse(Console.ReadLine()) - 1;
        manager.RecordEvent(index);
    }
}