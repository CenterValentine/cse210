using System;

public class Order
{
    List<Product> _products;
    Customer _customer;

    public Order(Customer customer, List<Product> products)
    {
        _products = products;
        _customer = customer;
    }

    public Order(Customer customer)
    {
        _customer = customer;
    }

    // add products
    public void AddProduct(Product product)
    {
        _products.Add(product);
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
        string packingLabel = "Picklist:\nPick# | Product Name:  |  Product_id: \n";
        int i = 1;
        foreach (Product product in _products)
        {

            // Console.WriteLine(product.GetProduct());
            packingLabel += $"{i}: {product.GetProduct().Split(",")[0]} | {product.GetProduct().Split(",")[1]} \n";
            i++;
        }
        return packingLabel;
    }

    public string ShippingLabel()
    {
        return $"Shipping Label:\n{_customer.GetCustomer().ToString()}";
    }

}
