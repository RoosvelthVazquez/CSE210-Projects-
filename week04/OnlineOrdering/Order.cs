using System.Collections.Generic;

public class Order
{
    // Member Variables
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    // MConstructor
    public Order(Customer customer)
    {
        _customer = customer;
    }

    // MemberFunctions
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public float GetTotalCost()
    {
        float total = 0;

        foreach (Product p in _products)
        {
            total += p.TotalCost();
        }

        if (_customer.LivesInUSA())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }

        return total;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";

        foreach (Product p in _products)
        {
            label += $"{p.GetName()} (ID: {p.GetId()})\n";
        }

        return label;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{_customer.GetName()}\n{_customer.GetAddressString()}";
    }
}
