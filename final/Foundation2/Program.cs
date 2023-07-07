using System;

class Program
{
    static void Main(string[] args)
    {
        Customer customer1 = new Customer("John", "123 Main St.", "Rexburg", "Idaho", "USA");
        List<Product> order1Products = new List<Product>(){
            new Product("Apple", 1, 0.99, 5),
            new Product("Banana", 2, 0.59, 8),
            new Product("Orange", 3, 1.25, 3)
        };
        Order order1 = new Order(customer1, order1Products);
        
        order1.GetPackingLabel();
        Console.WriteLine();
        order1.GetShippingLabel();
        Console.WriteLine();
        order1.DisplayTotalCost();
        Console.WriteLine("\n");

        Customer customer2 = new Customer("Jane", "555 West Ave.", "Oxford", "Oxfordshire", "England");
        List<Product> order2Products = new List<Product>(){
            new Product("Cheese", 4, 3.59, 2),
            new Product("Ham", 5, 12.99, 1)
        };
        Order order2 = new Order(customer2, order2Products);
        
        order2.GetPackingLabel();
        Console.WriteLine();
        order2.GetShippingLabel();
        Console.WriteLine();
        order2.DisplayTotalCost();
        Console.WriteLine();
    }
}