class Lecture : SocialEvent
{
    private string _speaker;
    private string _capacity;
    public Lecture(string title, string description, string date, string time, Address address, string speaker, string capacity) : base(title, description, date, time, address) 
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public string GetEventType()
    {
        return "Lecture";
    }
}