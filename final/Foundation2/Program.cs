using System;

class Program
{
    static void Main(string[] args)
    {
        //Create Address
        var address1 = new Address("954 Main St", "Springfield", "IL", "USA");
        var address2 = new Address("376 Elm St", "Toronto", "ON", "Canada");

        // Create customers
        var customer1 = new Customer("Doglas Monteiro", address1);
        var customer2 = new Customer("Benjamin Alves", address2);

        // Create Products
        var product1 = new Product("Notebook", "Dell1503", 800.00m, 1);
        var product2 = new Product("Mouse", "Mou1503", 20.00m, 2);
        var product3 = new Product("Keyboard", "Kbd1503", 50.00m, 1);

        //Create Orders
        var order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        var order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product1);

        //Add orders to the list
        var orders = new List<Order> {order1 , order2};

        //Display order Info
        foreach(var order in orders)
        {
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total Cost: ${order.CalculateTotalCost()}\n");
        }
    }    
}