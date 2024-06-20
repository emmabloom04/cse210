class Entry 
{
    private string _date;
    private string _response;

    public string GetDate() {
        DateTime theCurrentTime = DateTime.Now;
        _date = theCurrentTime.ToShortDateString();
        return _date;
    }
    public string GetResponse() {
        Prompt _prompt = new Prompt();
        Console.Write($"{_prompt} ");
        return _response = Console.ReadLine();
    }


}