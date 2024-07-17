class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateOrProvince;
    private string _country;
    private string _zipCode;
    public Address(string streetAddress, string city, string stateOrProvince, string country, string zipCode)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
        _zipCode = zipCode;
    }
    public Address(string streetAddress, string city, string stateOrProvince, string country) 
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
        _zipCode = "";
    }

    public string GetAddress()
    {
        return $"{_streetAddress}\n{_city}, {_stateOrProvince} {_zipCode}\n{_country}";
    }

    public string GetCountry()
    {
        return _country;
    }
}