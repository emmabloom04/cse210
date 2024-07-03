class Activity {
    string _nameOfActivity;
    int _time;
    string _activityDescription;
    List<string> _spinnerAnimations = new List<string> {"-", "\\", "|", "/"};

    public Activity(string nameOfActivity, string activityDescription) {
        _nameOfActivity = nameOfActivity;
        _activityDescription = activityDescription;
    }

    protected DateTime WelcomeMessage() {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_nameOfActivity} activity!");
        Thread.Sleep(1000);
        Console.WriteLine(_activityDescription);
        _time = GetTime();
        Thread.Sleep(1000);
        Console.WriteLine("Prepare to begin the activity.");
        Spinner();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_time);
        return endTime;
    }

    protected void CompletionMessage() {
        Console.Clear();
        Console.WriteLine("Great Job!!");
        Thread.Sleep(500);
        Console.WriteLine($"You completed the {_nameOfActivity} activity for a duration of {_time} seconds.");
        Spinner();
    }

    protected void Countdown(int countdownTime) {
        for (int i = countdownTime; i > 0; i--)
        {
            Console.Write($"{i}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    protected void Spinner() {
        for (int i = 0; i < 3; i++) {
            foreach (string animation in _spinnerAnimations) {
                Console.Write(animation);
                Thread.Sleep(500);
                Console.Write("\b \b");
            }
        }
    }

    private int GetTime() {
        Console.Write("How long would you like the duration of the activity? (in seconds) ");
        _time = int.Parse(Console.ReadLine());
        return _time;
    }
}