class Goals {
    List<Goal> _goals = new List<Goal>();
    Goal _goal;
    int _totalPoints;
    int _points;
    public Goals(List<Goal> goals, Goal goal, int totalPoints, int points) {
        _goals = goals;
        _goal = goal;
        _totalPoints = totalPoints;
        _points = points;
    }

    public List<Goal> AddToList() {
        _goals.Add(_goal);
        return _goals;
    }

    public List<Goal> RemoveFromList() {
        _goals.Remove(_goal);
        return _goals;
    }

    public int AddPoints() {
        _totalPoints += _points;
        return _totalPoints;
    }
}