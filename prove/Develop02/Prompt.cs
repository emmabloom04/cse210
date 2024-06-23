class Prompt
{
    private List<string> _prompts = new List<string> 
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What are three things you are grateful for today, and why?",
        "Write about a meaningful conversation you had recently. What made it special?",
        "What are three things you can do to take care of your mental health this week?",
        "What did you do today that made you feel proud of yourself?",
        "What was the most surprising part of your day?",
        "How did you spend your free time today?",
        "What was your most significant accomplishment today?",
        "What was something you did today that was outside of your comfort zone? How did it feel?"
    };
    private string _prompt;
    private static Random _randomGenerator = new Random();

    public string GetRandomPrompt() {
        
        int randomIndex = _randomGenerator.Next(_prompts.Count);
        _prompt = _prompts[randomIndex];
        return _prompt;
    }
}