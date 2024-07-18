using System;

public class Order
{
List<Product> _products;
Customer _customer;

public Order(Customer customer)
{
    _customer = customer;
    _products = new List<Product>();
}

public double TotalCost(){

}

public string PackingLabel(){

}

public string ShippingLabel(){

}

}
