using System.Runtime.CompilerServices;

class Entry 
{
    private string _date;
    private string _response;
    private string _prompt;

    public Entry() {

    }

    public Entry(string date, string prompt, string response) {
        date = _date;
        response = _response;
        prompt = _prompt;

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
        outputString = $"Date: {_date}#Prompt: {_prompt}#Response: {_response}";
        return outputString;
    }


}