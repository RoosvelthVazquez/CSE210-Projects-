using System;

class Program
{
    static void Main(string[] args)
    {
        // customer 1
        Address a1 = new Address("123 Apple St", "Miami", "FL", "USA");
        Customer c1 = new Customer("John Smith", a1);
        Order o1 = new Order(c1);

        o1.AddProduct(new Product("Keyboard", "KB100", 30f, 2));
        o1.AddProduct(new Product("Mouse", "MS200", 15f, 1));

        Console.WriteLine(o1.GetPackingLabel());
        Console.WriteLine(o1.GetShippingLabel());
        Console.WriteLine("Total Cost: $" + o1.GetTotalCost());

        Console.WriteLine("--------------------------");

        //Customer 2
        Address a2 = new Address("Av. Central 55", "CDMX", "MX", "Mexico");
        Customer c2 = new Customer("Luis Perez", a2);
        Order o2 = new Order(c2);

        o2.AddProduct(new Product("Headphones", "HD100", 50f, 1));
        o2.AddProduct(new Product("Microphone", "MC300", 120f, 1));

        Console.WriteLine(o2.GetPackingLabel());
        Console.WriteLine(o2.GetShippingLabel());
        Console.WriteLine("Total Cost: $" + o2.GetTotalCost());
    }
}