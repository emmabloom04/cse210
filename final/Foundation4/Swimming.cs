class Swimming : Exercise
{
    private double _laps;
    public Swimming(string date, double lengthOfExercise, double laps) : base(date, lengthOfExercise)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000 * 0.62;
    }

    public override double GetPace()
    {
        return GetLength() / GetDistance();
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetLength()) * 60;
    }

    public override string GetExerciseType()
    {
        return "Swimming";
    }
}