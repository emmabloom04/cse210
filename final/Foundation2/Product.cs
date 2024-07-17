class Product
{
    private string _name;
    private string _productId;
    private double _price;
    private double _totalProductPrice;
    private double _quantity;
    public Product(string name, string productId, double price, double quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public double CalculateTotalProductPrice()
    {
        _totalProductPrice = _price * _quantity;
        return _totalProductPrice;
    }

    public void DisplayProduct()
    {
        Console.WriteLine($"{_productId} - {_name} ({_quantity}): ${_totalProductPrice}");
    }
}