class Menu
{

    public int DisplayMenu()
    {
        Console.WriteLine("\nWelcome to the Eternal Quest Program!");
        Console.WriteLine("\nPick an option:");
        Console.WriteLine("\n1. Write new goal");
        Console.WriteLine("2. Record an event");
        Console.WriteLine("3. Remove goal from list");
        Console.WriteLine("4. Load goals");
        Console.WriteLine("5. Write goals to a file");
        Console.WriteLine("6. Display goals");
        Console.WriteLine("7. Quit");
        return int.Parse(Console.ReadLine());
    }

    public int DisplayCreateGoalMenu()
    {
        Console.WriteLine("\nPick what kind of goal you would like to create:");
        Console.WriteLine("\n1. Simple goal");
        Console.WriteLine("2. Eternal goal");
        Console.WriteLine("3. Checklist goal");
        return int.Parse(Console.ReadLine());
    }

    public Goal InterpretChoice(int goalChoice)
    {
        if (goalChoice == 1)
        {
            SimpleGoal simpleGoal = new SimpleGoal();
            simpleGoal.RunGoal();
            return simpleGoal;
        }
        else if (goalChoice == 2)
        {
            EternalGoal eternalGoal = new EternalGoal();
            eternalGoal.RunGoal();
            return eternalGoal;
        }
        else
        {
            ChecklistGoal checklistGoal = new ChecklistGoal();
            checklistGoal.RunGoal();
            return checklistGoal;
        }
    }
}