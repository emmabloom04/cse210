class Entry 
{
    private string _date;
    private string _response;
    private string _prompt;

    public Entry() {

    }

    public Entry(string date, string prompt, string response) {

    }

    public string GetDate() {
        DateTime theCurrentTime = DateTime.Now;
        _date = theCurrentTime.ToShortDateString();
        return _date;
    }
    public string GetResponse() {

        Prompt _promptGenerator = new Prompt();
        _prompt = _promptGenerator.GetRandomPrompt();
        Console.Write($"{_prompt} ");
        _response = Console.ReadLine();
        return _response;
    }

    public override string ToString() {
        
        string outputString = "";
        outputString = $"{_date}#{_prompt}#{_response}";
        return outputString;
    }


}