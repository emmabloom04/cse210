class OutdoorGathering : SocialEvent
{
    private string _weather;
    public OutdoorGathering(string title, string description, string date, string time, Address address, string weather) : base(title, description, date, time, address)
    {
        _weather = weather;
    }

    public string GetEventType()
    {
        return "Outdoor Gathering";
    }
}