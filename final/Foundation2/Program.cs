using System;
using System.Collections.Generic;
using System.Text;
public class Program
{
    public static void Main()
    {
       
        Address address1 = new Address("123 Main St", "City", "State", "USA");
        Address address2 = new Address("456 Elm St", "Town", "Province", "Canada");

      
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

     
        Product product1 = new Product()
        {
            productName = "Product 1",
            productId = 1,
            price = 10.0,
            quantity = 2
        };

        Product product2 = new Product()
        {
            productName = "Product 2",
            productId = 2,
            price = 15.0,
            quantity = 1
        };

        Product product3 = new Product()
        {
            productName = "Product 3",
            productId = 3,
            price = 20.0,
            quantity = 3
        };

       
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

       
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: {order1.CalculateTotalCost()}");

        Console.WriteLine();

        
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: {order2.CalculateTotalCost()}");

        Console.ReadLine();
    }
}