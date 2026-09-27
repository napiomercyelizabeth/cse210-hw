using System;

class Program
{
    static void Main(string[] args)
    {
        // Order 1: USA Customer
        Address address1 = new Address("123 Main Street", "Rexburg", "ID", "USA");
        Customer customer1 = new Customer("John Doe", address1);
        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Wireless Mouse", "P101", 25.50, 2));
        order1.AddProduct(new Product("Mechanical Keyboard", "P102", 75.00, 1));
        order1.AddProduct(new Product("Mouse Pad", "P103", 12.00, 1));

        // Order 2: International Customer (Uganda)
        Address address2 = new Address("Plot 45 Kampala Road", "Kampala", "Central", "Uganda");
        Customer customer2 = new Customer("Mercy Napio", address2);
        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("HD Web Camera", "P201", 45.00, 1));
        order2.AddProduct(new Product("USB-C Hub", "P202", 30.00, 2));

        // Display Order 1 Details
        Console.WriteLine("==================================================");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"\nTotal Price: ${order1.CalculateTotalCost():F2}");

        // Display Order 2 Details
        Console.WriteLine("==================================================");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"\nTotal Price: ${order2.CalculateTotalCost():F2}");
        Console.WriteLine("==================================================");
    }
}