class Lecture : SocialEvent
{
    private string _speaker;
    private int _capacity;
    public Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity) : base(title, description, date, time, address) 
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    private string GetEventType()
    {
        return "Lecture";
    }

    public void DisplayInfo() 
    {
        Console.WriteLine($"Event type: {GetEventType()}");
        DisplayEventInfo();
        Console.WriteLine($"Speaker: {_speaker} Capacity: {_capacity}");
    }
}