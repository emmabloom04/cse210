class Reception : SocialEvent
{
    private string _email;
    public Reception(string title, string description, string date, string time, Address address, string email) : base(title, description, date, time, address) {
        _email = email;
    }

    private string GetEventType() 
    {
        return "Reception";
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Event type: {GetEventType()}");
        DisplayEventInfo();
        Console.WriteLine($"Please RSVP at {_email}");
    }
}