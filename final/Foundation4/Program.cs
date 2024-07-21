using System;

class Program
{
    static void Main(string[] args)
    {
        List<Exercise> exercises = new List<Exercise>();

        Running running = new Running("September 13", 30, 3);
        Cycling cycling = new Cycling("August 14", 30, 15);
        Swimming swimming = new Swimming("February 5", 45, 20);

        exercises.Add(running);
        exercises.Add(cycling);
        exercises.Add(swimming);

        foreach (Exercise exercise in exercises)
        {
            exercise.DisplaySummary();
        }
    }
}