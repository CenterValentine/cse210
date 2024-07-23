using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Address address = new Address("123 Main St", "Springfield", "IL", "62701");
        Customer customer = new Customer("Mr. E", address);
        Product product1 = new Product("Skunk Fur Coat", "P1001", 10.00, 3);
        Product product2 = new Product("Refurbished Pinecones", "P1002", 30.00, 1);
        Product product3 = new Product("Fragrence", "P1003", 50.00, 2);
        Product product4 = new Product("Tire Launcher", "P9000", 500, 1);
        Product product5 = new Product("Fitness DooHickey", "P90X", 100, 2);

        List<Product> productsOrder1 = new List<Product> { product1, product2, product3 };
        List<Product> productsOrder2 = new List<Product> { product4, product5 };
        Order order1 = new Order(customer, productsOrder1);
        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine("\nTotal Price: $" + order1.TotalPrice());
        Console.WriteLine("\n\n");
        Order order2 = new Order(customer, productsOrder2);
        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine("\nTotal Price: $" + order2.TotalPrice());



    }
}