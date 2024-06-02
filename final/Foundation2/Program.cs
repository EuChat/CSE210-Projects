using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Order order1 = new Order(new Customer("Kevin", new Address("Pizza Avenue", "Montella", "California", "Usa")));
        order1.AddProduct(new Product("Rice", "a1", 50, 2));
        order1.AddProduct(new Product("Coffee", "b1", 100, 1));
        order1.AddProduct(new Product("Apples", "b2", 10, 20));

        Order order2 = new Order(new Customer("Victor", new Address("Bread street", "Paris","Rust",  "France")));
        order2.AddProduct(new Product("Apples", "b2", 10, 10));
        order2.AddProduct(new Product("Diamond", "az7", 500, 1));

        Console.WriteLine("Order 1");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine(order1.CalculateTotalCost());
        Console.WriteLine("");
        Console.WriteLine("Order 2");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine(order2.CalculateTotalCost());
    }
}