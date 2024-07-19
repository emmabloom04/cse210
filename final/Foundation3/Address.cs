class Address 
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _zipCode;
    private string _country;
    public Address(string streetAddress, string city, string state, string zipCode, string country) 
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _zipCode = zipCode;
        _country = country;
    }

    public string GetAddress() 
    {
        return $"{_streetAddress}\n{_city}, {_state} {_zipCode}\n{_country}";
    }

    public void DisplayAddress()
    {
        Console.WriteLine(GetAddress());
    }
}