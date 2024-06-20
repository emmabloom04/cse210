class Prompt
{
    private List<string> _prompts = new List<string> {"Prompt 1", "Prompt 2", "Prompt 3", "Prompt 4", "Prompt 5"};
    private string _prompt;

    public string GetRandomPrompt() {
        Random randomGenerator = new Random();
        int randomIndex = randomGenerator.Next(_prompts.Count);
        _prompt = _prompts[randomIndex];
        return _prompt;
    }
}