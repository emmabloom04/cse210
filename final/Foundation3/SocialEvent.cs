class SocialEvent {
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;
    public SocialEvent(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string GetTitle()
    {
        return _title;
    }

    public string GetDescription()
    {
        return _description;
    }

    public string GetDate()
    {
        return _date;
    }

    public string GetTime()
    {
        return _time;
    }

    public Address GetAddress()
    {
        return _address;
    }

    public void DisplayEventInfo() 
    {
        Console.WriteLine($"Event title: {_title}\nDescription: {_description} Date: {_date}, Time: {_time}\nLocation:\n{_address.GetAddress()}");
    }
}