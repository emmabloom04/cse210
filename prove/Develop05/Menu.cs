class Menu {

    Goals _goals = new Goals();

    public void DisplayMenu() {
        Console.WriteLine("\nWelcome to the Eternal Quest Program!");
        Console.WriteLine("What would you like to do?");
        Console.WriteLine("\n1. Write new goal");
        Console.WriteLine("2. Record an event");
        Console.WriteLine("3. Load goals");
        Console.WriteLine("4. Write goals to a file");
        Console.WriteLine("5. Display goals");
        Console.WriteLine("6. Quit");
    }

    public void InterpretChoice(int userChoice) {
        if (userChoice == 1) {
            int goalChoice = 0;
            do {
                DisplayGoalOptions();
                goalChoice = int.Parse(Console.ReadLine());
            } while (goalChoice > 3 || goalChoice < 1);
            Goal goal = WriteGoal(goalChoice);
            _goals.AddToList(goal);
        }
        else if (userChoice == 2) {
            Console.WriteLine("\nHere you will record a completion of a goal!");
        }
        else if (userChoice == 3) {
            Console.WriteLine("\nThe program will do its magic and load in information from the file of your choice!");
        }
        else if (userChoice == 4) {
            Console.WriteLine("\nThe program will do some magic and write what's already in this program to a file of your choice!");
        }
        else if (userChoice == 5) {
            _goals.DisplayList();
        }
    }

    private Goal WriteGoal(int goalChoice) {
        Goal goal = new SimpleGoal("", "", false, 0);
        if (goalChoice == 1) {
            Console.Write("Name of simple goal: ");
            string nameOfGoal = Console.ReadLine();
            Console.Write("Goal description: ");
            string goalDescription = Console.ReadLine();
            Console.Write("Number of points you want to receive for completing the goal: ");
            int points = int.Parse(Console.ReadLine());
            SimpleGoal simpleGoal = new SimpleGoal(nameOfGoal, goalDescription, false, points);
            goal = simpleGoal;
        }
        else if (goalChoice == 2) {
            Console.Write("Name of eternal goal: ");
            string nameOfGoal = Console.ReadLine();
            Console.Write("Goal description: ");
            string goalDescription = Console.ReadLine();
            Console.Write("Number of points you want to receive every time you complete the goal: ");
            int points = int.Parse(Console.ReadLine());
            EternalGoal eternalGoal = new EternalGoal(nameOfGoal, goalDescription, false, points); 
            goal = eternalGoal;
        }
        else if (goalChoice == 3) {
            Console.Write("Name of checklist goal: ");
            string nameOfGoal = Console.ReadLine();
            Console.Write("Goal description: ");
            string goalDescription = Console.ReadLine();
            Console.Write("Number of times you want to complete this goal: ");
            int goalNumber = int.Parse(Console.ReadLine());
            Console.Write("Number of points you want to receive each time you complete this goal: ");
            int points = int.Parse(Console.ReadLine());
            Console.Write("Bonus number of points you want to receive after completing the goal the desired number of times: ");
            int bonus = int.Parse(Console.ReadLine());
            ChecklistGoal checklistGoal = new ChecklistGoal(nameOfGoal, goalDescription, false, points, bonus, 0, goalNumber);
            goal = checklistGoal;
        }
        return goal;
    }

    private void DisplayGoalOptions() {
        Console.WriteLine("\nPick what kind of goal you would like to write:");
        Console.WriteLine("\n1. Simple goal");
        Console.WriteLine("2. Eternal goal");
        Console.WriteLine("3. Checklist goal");
    }
}