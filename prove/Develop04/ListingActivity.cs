class ListingActivity : Activity {
    List<string> _prompts = new List<string> {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that helped you this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    string _prompt;
    public ListingActivity(string nameOfActivity, string activityDescription) : base(nameOfActivity, activityDescription) {
        _prompt = PickRandomPrompt();
    }

    private string PickRandomPrompt() {
        Random randomGenerator = new Random();
        int randomIndex = randomGenerator.Next(_prompts.Count);
        _prompt = _prompts[randomIndex];
        return _prompt;
    }

    private void DisplayPrompt() {
        Console.WriteLine($"-- {_prompt} --");
    }
    public void RunActivity() {
        DateTime endTime = WelcomeMessage();
        DisplayPrompt();
        DateTime startTime = DateTime.Now;
        int count = 0;
        while (startTime < endTime) {
            Console.ReadLine();
            count += 1;
            startTime = DateTime.Now;
        }
        Console.WriteLine($"You listed {count} things.");
        Thread.Sleep(2000);
        CompletionMessage();
    }
}