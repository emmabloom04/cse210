class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;
    private double _shippingCost;
    private double _totalCost;
    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    private double GetShippingCost()
    {
        if (_customer.InUsOrNot() == true)
        {
            _shippingCost = 5;
        }
        else
        {
            _shippingCost = 35;
        }
        return _shippingCost;
    }

    public void DisplayShippingLabel()
    {
        Console.WriteLine("Shipping label:");
        Console.WriteLine($"\n{_customer.GetCustomerInfo()}");
    }

    public void DisplayPackingLabel()
    {
        _totalCost = CalculateTotalPrice();
        Console.WriteLine("Packing label:");
        Console.WriteLine();
        Console.WriteLine($"Total price: ${_totalCost}");
        foreach (Product product in _products) 
        {
            product.DisplayProduct();
        }

    }

    private double CalculateTotalPrice()
    {
        foreach (Product product in _products)
        {
            _totalCost += product.CalculateTotalProductPrice();
        }
        _shippingCost = GetShippingCost();
        _totalCost += _shippingCost;
        return _totalCost;
    }
}