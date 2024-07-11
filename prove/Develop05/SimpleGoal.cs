class SimpleGoal : Goal {
    public SimpleGoal(string nameOfGoal, string goalDescription, bool finished, int points) : base(nameOfGoal, goalDescription, finished, points) {

    }

    public override bool FinishedOrNot()
    {
        throw new NotImplementedException();
    }
}