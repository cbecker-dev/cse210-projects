using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Kalispell", "MT", "USA");
        Customer customer1 = new Customer("Charity Becker", address1);

        Product product1 = new Product("Laptop", "A1001", 800, 1);
        Product product2 = new Product("Mouse", "B2002", 25, 2);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Console.WriteLine("Order 1 Packing label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Order 1 Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Order 1 Total Cost: $" + order1.GetTotalCost());
        Console.WriteLine();

        Address address2 = new Address("45 River Rd", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Liam Smith", address2);

        Product product3 = new Product("Tablet", "C3003", 300, 2);
        Product product4 = new Product("Stylus Pen", "D4004", 30, 3);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        Console.WriteLine("Order 2 Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Order 2 Shipping Label");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Order 2 Total Cost: $" + order2.GetTotalCost());
    }

}