using System;

class Program
{
    static void Main(string[] args)
    {
        int userChoice = 0;
        int goalChoice = 0;
        Goals goals = new Goals();

        Menu menu = new Menu();
        while (userChoice != 7)
        {
            do
            {
                Console.WriteLine();
                goals.DisplayScore();
                userChoice = menu.DisplayMenu();
            } while (userChoice > 7 || userChoice < 1);
            if (userChoice == 1)
            {
                do
                {
                    goalChoice = menu.DisplayCreateGoalMenu();
                } while (goalChoice > 3 || goalChoice < 1);
                Goal goal = menu.InterpretChoice(goalChoice);
                goals.AddGoal(goal);
            }
            else if (userChoice == 2)
            {
                goals.DisplayGoals();
                Console.Write("\nWhich goal did you complete? ");
                int goalComplete = int.Parse(Console.ReadLine());
                Goal goal = goals.FindGoalInList(goalComplete);
                goals.RecordEvent(goal);
                goals.DisplayGoals();
            }
            else if (userChoice == 3)
            {
                goals.DisplayGoals();
                Console.Write("Which goal which you like to remove? ");
                int goalToRemove = int.Parse(Console.ReadLine());
                Goal goal = goals.FindGoalInList(goalToRemove);
                goals.RemoveGoal(goal);
                goals.DisplayGoals();
            }
            else if (userChoice == 4)
            {
                goals.LoadGoals();
            }
            else if (userChoice == 5)
            {
                goals.SaveGoals();
            }
            else if (userChoice == 6)
            {
                goals.DisplayGoals();
            }
        }
    }
}
