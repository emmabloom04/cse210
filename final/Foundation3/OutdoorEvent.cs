class OutdoorGathering : SocialEvent
{
    private string _weather;
    public OutdoorGathering(string title, string description, string date, string time, Address address, string weather) : base(title, description, date, time, address)
    {
        _weather = weather;
    }

    private string GetEventType()
    {
        return "Outdoor Gathering";
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Event type: {GetEventType()}");
        DisplayEventInfo();
        Console.WriteLine($"Weather: {_weather}");
    }
}