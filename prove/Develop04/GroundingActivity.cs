class GroundingActivity : Activity {
    List<string> _senses = new List<string> {
        "What is something you can feel?",
        "What is something you can see?",
        "What is something you can hear?",
        "What is something you can smell?",
        "What is something you taste?"
    };
    public GroundingActivity(string nameOfActivity, string activityDescription) : base(nameOfActivity, activityDescription) {

    }
    public void RunActivity() {
        DateTime endTime = WelcomeMessage();
        DateTime startTime = DateTime.Now;
        while (startTime < endTime) {
            Console.Clear();
            while (startTime < endTime) {
                foreach (string sense in _senses) {
                    Console.Clear();
                    Console.WriteLine($"-- {sense} --");
                    for (int i = 0; i < 2; i++) {
                        Spinner();
                    }
                    startTime = DateTime.Now;
                    if (startTime > endTime) {
                        break;
                    }
                }
            }
        }
        CompletionMessage();
    }
}