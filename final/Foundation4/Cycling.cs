class Cycling : Exercise
{
    private double _speed;
    public Cycling(string date, double lengthOfExercise, double speed) : base(date, lengthOfExercise)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return (_speed * GetLength()) / 60;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override string GetExerciseType()
    {
        return "Cycling";
    }
}