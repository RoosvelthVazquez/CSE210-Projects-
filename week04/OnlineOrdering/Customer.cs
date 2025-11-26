public class Customer
{
    // Member variables
    private string _name;
    private Address _address;

    // Constructor
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // Member functions
    public bool LivesInUSA()
    {
        return _address.IsUSA();
    }

    public string GetName()
    {
        return _name;
    }

    public string GetAddressString()
    {
        return _address.GetFullAddress();
    }
}
