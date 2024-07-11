abstract class Goal {
    string _nameOfGoal;
    string _goalDescription;
    bool _finished;
    int _points;
    public Goal(string nameOfGoal, string goalDescription, bool finished, int points) {
        _nameOfGoal = nameOfGoal;
        _goalDescription = goalDescription;
        _finished = finished;
        _points = points;
    }

    public abstract bool FinishedOrNot();

    public virtual void DisplayGoal() {

    }

    public string GetGoalName() {
        return _nameOfGoal;
    }

    public string GetGoalDescription() {
        return _goalDescription;
    }

    public virtual int GetPoints() {
        return _points;
    }

    public override string ToString()
    {
        return base.ToString();
    }
}