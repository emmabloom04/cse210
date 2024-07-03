class Activity {
    string _nameOfActivity;
    // int _time;
    string _activityDescription;

    public Activity(string nameOfActivity, string activityDescription) {
        _nameOfActivity = nameOfActivity;
        _activityDescription = activityDescription;
    }

    protected void Countdown(int countdownTime) {
        for (int i = countdownTime; i > 0; i--)
        {
            Console.Write($"{i}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    // public int GetTime() {
    //     Console.Write("How long would you like the duration of the activity? (in seconds) ");
    //     _time = int.Parse(Console.ReadLine());
    //     return _time;
    // }
}