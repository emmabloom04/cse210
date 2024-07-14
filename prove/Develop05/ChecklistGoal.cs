class ChecklistGoal : Goal
{
    private string _goalType;
    private int _numberOfCompletions;
    private int _maxGoals;
    private int _bonusPoints;
    public ChecklistGoal(string name, string description, int points, bool status, int completions, int max, int bonus) : base(name, description, points, status)
    {
        _numberOfCompletions = completions;
        _maxGoals = max;
        _bonusPoints = bonus;
    }
    public ChecklistGoal()
    {

    }

    public override void RunGoal()
    {
        ObtainName();
        ObtainDescription();
        ObtainPoints();
        ObtainMaxGoal();
        ObtainBonusPoints();
    }

    public override string GetGoalType()
    {
        _goalType = "Checklist Goal";
        return _goalType;
    }

    public override int RecordEvent()
    {
        _numberOfCompletions++;
        if (_maxGoals == _numberOfCompletions)
        {
            SetStatus(true);
            return GetPoints() + _bonusPoints;
        }
        else
        {
            SetStatus(false);
            return GetPoints();
        }
    }

    public override string ToString()
    {
        return $"{GetGoalType()}#{GetName()}#{GetDescription()}#{GetPoints()}#{GetStatus()}#{_numberOfCompletions}#{_maxGoals}#{_bonusPoints}";
    }

    public override string ListGoal()
    {
        string complete;
        if (GetStatus() == false)
        {
            complete = "[ ]";
        }
        else
        {
            complete = "[X]";
        }
        return $"{complete} {GetName()} ({GetDescription()} - Completed: {_numberOfCompletions}/{_maxGoals})";
    }

    private int ObtainMaxGoal()
    {
        Console.Write("Number of times you want to complete this goal: ");
        _maxGoals = int.Parse(Console.ReadLine());
        return _maxGoals;
    }

    private int ObtainBonusPoints()
    {
        Console.Write("Bonus you want to receive after finishing the goal the max number of times: ");
        _bonusPoints = int.Parse(Console.ReadLine());
        return _bonusPoints;
    }
}