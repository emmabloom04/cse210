class BreathingActivity : Activity {
    public BreathingActivity(string nameOfActivity, string activityDescription) : base(nameOfActivity, activityDescription) {

    }

    private void BreatheIn() {
        Console.Clear();
        Console.Write("Breathe in...  ");
        Countdown(5);

    }

    private void Hold() {
        Console.Clear();
        Console.Write("Hold... ");
        Countdown(5);
    }

    private void BreatheOut() {
        Console.Clear();
        Console.Write("Breathe out...  ");
        Countdown(5);
    }

    public void RunActivity() {
        for (int i = 0; i < 5; i++) {
            BreatheIn();
            Hold();
            BreatheOut();
        }
    }
}