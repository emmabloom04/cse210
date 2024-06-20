class Entry 
{
    private string _date;
    private string _response;

    public string GetDate() {
        DateTime theCurrentTime = DateTime.Now;
        _date = theCurrentTime.ToShortDateString();
        return _date;
    }

    public void GenerateRandomPrompt() {
        Prompt _prompt = new Prompt();
        Console.WriteLine(_prompt.GetRandomPrompt());
    }

}