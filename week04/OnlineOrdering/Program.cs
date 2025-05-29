using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("67 Queens St", "New York", "NY", "USA");
        Customer customer1 = new Customer("Lebohang Sebata", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "DELL", 2333.99, 1));
        order1.AddProduct(new Product("Mouse", "LENOVO", 5.50, 2));

        Address address2 = new Address("45 Oxford Road", "London", "Cambridge", "UK");
        Customer customer2 = new Customer("James Bond", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Smartphone", "SAMSUNG", 250.00, 1));
        order2.AddProduct(new Product("Charger", "CHARGE", 10.00, 3));

        Console.WriteLine("Order 1 - USA Customer");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():F2}\n");

        Console.WriteLine("Order 2 - International Customer");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():F2}");
    }
}
