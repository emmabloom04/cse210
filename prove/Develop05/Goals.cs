class Goals
{
    private List<Goal> _goals = new List<Goal>();
    private string _filename;
    private int _totalScore;

    public Goals()
    {

    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void RemoveGoal(Goal goal)
    {
        _goals.Remove(goal);
    }

    public void LoadGoals()
    {
        _filename = ObtainFileName("Which file would you like to load your goals from? ");

        using (StreamReader reader = new StreamReader(_filename))
        {
            _totalScore = int.Parse(reader.ReadLine());

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split("#");
                string goalType = parts[0];
                int points = int.Parse(parts[3]);
                bool status = bool.Parse(parts[4]);
                if (goalType == "Simple Goal")
                {
                    SimpleGoal simpleGoal = new SimpleGoal(parts[1], parts[2], points, status);
                    AddGoal(simpleGoal);
                }
                else if (goalType == "Eternal Goal")
                {
                    int completions = int.Parse(parts[5]);
                    EternalGoal eternalGoal = new EternalGoal(parts[1], parts[2], points, status, completions);
                    AddGoal(eternalGoal);
                }
                else if (goalType == "Checklist Goal")
                {
                    int completions = int.Parse(parts[5]);
                    int max = int.Parse(parts[6]);
                    int bonus = int.Parse(parts[7]);
                    ChecklistGoal checklistGoal = new ChecklistGoal(parts[1], parts[2], points, status, completions, max, bonus);
                    AddGoal(checklistGoal);
                }
            }
        }
    }

    public void SaveGoals()
    {
        _filename = ObtainFileName("Which file would you like to save your goals to? ");
        using (StreamWriter writer = new StreamWriter(_filename))
        {
            writer.WriteLine(_totalScore);
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.ToString());
            }
        }
    }

    public void DisplayGoals()
    {
        int counter = 1;
        Console.WriteLine();
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{counter}. {goal.ListGoal()}");
            counter++;
        }
        Thread.Sleep(2000);
    }

    public void DisplayScore()
    {
        Console.WriteLine($"You have {_totalScore} points.");
    }

    public void RecordEvent(Goal goal)
    {
        int index = _goals.IndexOf(goal);
        int points = goal.RecordEvent();
        _goals[index] = goal;
        _totalScore += points;
    }

    public Goal FindGoalInList(int index)
    {
        index = index - 1;
        return _goals[index];
    }

    private string ObtainFileName(string prompt)
    {
        Console.Write(prompt);
        _filename = Console.ReadLine();
        return _filename;
    }
}