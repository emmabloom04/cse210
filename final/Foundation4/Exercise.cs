abstract class Exercise
{
    private string _date;
    private double _lengthOfExercise;
    public Exercise(string date, double lengthOfExercise)
    {
        _date = date;
        _lengthOfExercise = lengthOfExercise;
    }

    public string GetDate()
    {
        return _date;
    }

    public double GetLength()
    {
        return _lengthOfExercise;
    }

    public abstract double GetDistance();

    public abstract double GetSpeed();

    public abstract double GetPace();

    public abstract string GetExerciseType();

    public string GetSummary()
    {
        return $"{_date} {GetExerciseType()} ({_lengthOfExercise} minutes) - Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }

    public void DisplaySummary()
    {
        Console.WriteLine($"{_date} {GetExerciseType()} ({_lengthOfExercise} minutes) - Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile");
    }
}