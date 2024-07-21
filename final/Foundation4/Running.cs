class Running : Exercise 
{
    private double _distance;
    public Running(string date, double lengthOfExercise, double distance) : base(date, lengthOfExercise)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetPace()
    {
        return GetLength() / _distance;
    }

    public override double GetSpeed()
    {
        return (_distance / GetLength()) * 60;
    }

    public override string GetExerciseType()
    {
        return "Running";
    }
}