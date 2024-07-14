class SimpleGoal : Goal
{
    private string _goalType;
    public SimpleGoal(string name, string description, int points, bool status) : base(name, description, points, status)
    {

    }

    public SimpleGoal()
    {

    }

    public override void RunGoal()
    {
        ObtainName();
        ObtainDescription();
        ObtainPoints();
    }

    public override string GetGoalType()
    {
        _goalType = "Simple Goal";
        return _goalType;
    }

    public override int RecordEvent()
    {
        SetStatus(true);
        return GetPoints();
    }

    public override string ToString()
    {
        return $"{GetGoalType()}#{GetName()}#{GetDescription()}#{GetPoints()}#{GetStatus()}";
    }
}