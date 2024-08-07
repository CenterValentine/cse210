using System;

public class Product
{
    private string _name;
    private string _productId;

    private double _price;

    private int _quantity;

    public Product(string name, string productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public string GetProduct()
    {
        // Console.WriteLine($"Products: {_name}, {_productId}");
        return $"{_name}, {_productId}";
    }

    public double TotalCost()
    {
        return _price * _quantity;
    }

}