using System;

class Program
{
    static void Main(string[] args)
    {

        Customer customer;
        Address address;
        Product product;
        List<Product> products = new List<Product>();
        Order order;

        address = new Address("1234-Elm", "Springfield", "Illinois", "USA");
        customer = new Customer("Carlos Perez", address);

        product = new Product("soup can", 0001, 5.00, 5);
        products.Add(product);
        product = new Product("Towels", 0023, 8.50, 2);
        products.Add(product);
        product = new Product("computer", 2512, 750.00, 1);
        products.Add(product);

        order = new Order(customer, products);
        Console.WriteLine($"Packing Label:\n{order.PackingLabel()}");
        Console.WriteLine($"\nShipping Label:\n{order.ShippingLabel()}");
        Console.WriteLine($"\nTotal Price Order: {order.TotalPrice()}\n");
        

        products = new List<Product>();
        address = new Address("4568-Silver", "Tijuana", "Baja California", "México");
        customer = new Customer("Susan Gomez", address);

        product = new Product("T-shirt", 2135, 15.00, 2);
        products.Add(product);
        product = new Product("Shoes", 7823, 45.00, 1);
        products.Add(product);
        product = new Product("Dress", 9812, 35.00, 2);
        products.Add(product);

        order = new Order(customer, products);
        Console.WriteLine($"Packing Label:\n{order.PackingLabel()}");
        Console.WriteLine($"\nShipping Label:\n{order.ShippingLabel()}");
        Console.WriteLine($"\nTotal Price Order: {order.TotalPrice()}\n");



    }
}