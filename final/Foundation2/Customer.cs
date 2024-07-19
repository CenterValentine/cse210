using System;
using System.Runtime.CompilerServices;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string GetCustomer()
    {
        return $"{_name} \n {_address.GetAddress()}";
    }

    public bool IsLivingInUSA()
    {
        return _address.IsLivingInUSA();
    }
}