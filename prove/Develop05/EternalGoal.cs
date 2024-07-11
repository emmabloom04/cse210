class EternalGoal : Goal {
    public EternalGoal(string nameOfGoal, string goalDescription, bool finished, int points) : base(nameOfGoal, goalDescription, finished = false, points) {

    }

    public override bool FinishedOrNot()
    {
        throw new NotImplementedException();
    }
}