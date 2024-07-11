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

    public virtual int GetPoints() {
        return _points;
    }

    public string GetNameOfGoal() {
        return _nameOfGoal;
    }

    public string GetGoalDescription() {
        return _goalDescription;
    }

    public override string ToString(){
        string complete;
        if (_finished == false) {
            complete = "[ ]";
        }
        else {
            complete = "[X]";
        }
        return $"{complete} {_nameOfGoal} ({_goalDescription})";
    }
}