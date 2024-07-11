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
        if (_numberCompleted == _goalNumber) {
            return true;
        }
        else {
            return false;
        }
    }

    public override int GetPoints()
    {
        int totalPoints;
        bool finished;
        finished = FinishedOrNot();
        if (finished == false) {
            totalPoints = GetPoints();
        }
        else {
            totalPoints = GetPoints() + _bonus;
        }
        return totalPoints;
    }

    public override string ToString()
    {
        string complete;
        bool finished = FinishedOrNot();
        if (finished == false) {
            complete = "[ ]";
        }
        else {
            complete = "[X]";
        }
        return $"{complete} {GetNameOfGoal()} ({GetGoalDescription()}) - Completed {_numberCompleted}/{_goalNumber}";
    }
}