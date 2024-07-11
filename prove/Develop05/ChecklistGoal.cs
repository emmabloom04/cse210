class ChecklistGoal : Goal {
    int _bonus;
    int _numberCompleted;
    int _goalNumber;
    public ChecklistGoal(string nameOfGoal, string goalDescription, bool finished, int points, int bonus, int numberCompleted, int goalNumber) : base(nameOfGoal, goalDescription, finished, points) {
        _bonus = bonus;
        _numberCompleted = numberCompleted;
        _goalNumber = goalNumber;
    }

    public override bool FinishedOrNot()
    {
        throw new NotImplementedException();
    }

    public override void DisplayGoal()
    {
        base.DisplayGoal();
    }

    public override int GetPoints()
    {
        return base.GetPoints();
    }

    public override string ToString()
    {
        return base.ToString();
    }
}