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
}