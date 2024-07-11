class Goals {
    List<Goal> _goals = new List<Goal>();
    public Goals() {

    }

    public List<Goal> AddToList(Goal goal) {
        _goals.Add(goal);
        return _goals;
    }

    public List<Goal> RemoveFromList(Goal goal) {
        _goals.Remove(goal);
        return _goals;
    }

    public void DisplayList() {
        int counter = 1;
        foreach (Goal goal in _goals) {
            Console.WriteLine($"{counter}. {goal.ToString()}");
            counter++;
        }
    }

    // public int AddPoints() {
    //     _totalPoints += _points;
    //     return _totalPoints;
    // }
}