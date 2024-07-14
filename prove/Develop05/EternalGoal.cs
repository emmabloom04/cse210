class EternalGoal : Goal
{
    private string _goalType;
    private int _numberOfCompletions;
    public EternalGoal(string name, string description, int points, bool status, int completions) : base(name, description, points, status = false)
    {
        _numberOfCompletions = completions;
    }
    public EternalGoal()
    {

    }

    public override void RunGoal()
    {
        ObtainName();
        ObtainDescription();
        ObtainPoints();
        SetStatus(false);
    }

    public override string GetGoalType()
    {
        _goalType = "Eternal Goal";
        return _goalType;
    }

    public override int RecordEvent()
    {
        _numberOfCompletions++;
        SetStatus(false);
        return GetPoints();
    }

    public override string ToString()
    {
        return $"{GetGoalType()}#{GetName()}#{GetDescription()}#{GetPoints()}#{GetStatus()}#{_numberOfCompletions}";
    }

    public override string ListGoal()
    {
        string complete;
        complete = "[ ]";
        // return $"{complete} {_name} ({_description})";
        return $"{complete} {GetName()} ({GetDescription()} - Completed: {_numberOfCompletions} times)";
    }
}