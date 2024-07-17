class Customer
{
    private string _name;
    private Address _address;
    private string _country;
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
        _country = _address.GetCountry();
    }

    public string GetCustomerInfo()
    {
        return $"{_name}\n{_address.GetAddress()}";
    }

    public bool InUsOrNot()
    {
        if (_country == "US")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}