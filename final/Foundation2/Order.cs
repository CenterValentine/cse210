using System;

public class Order
{
    List<Product> _products;
    Customer _customer;

    public Order(Customer customer)
    {
        _products = new List<Product>();
        _customer = customer;
    }


    public double TotalPrice()
    {
        double total = 0;
        foreach (Product product in _products)
        {
            total += product.TotalCost();
        }
        return total + ShippingCost();
    }

    public double ShippingCost()
    {
        if (_customer.IsLivingInUSA())
        {
            return 5;
        }
        else
        {
            return 35;
        }
    }

    public string PackingLabel()
    {
        string packingLabel = "Product Name:  |  Product_id: \n";
        int i = 1;
        foreach (Product product in _products)
        {
            packingLabel += $"{i}: {product.GetProduct()} \n";
        }
        return packingLabel;
    }

    public string ShippingLabel()
    {
        return _customer.GetCustomer();
    }

}
