public class Product
{
    // Member variables
    private string _name;
    private string _id;
    private float _price;
    private int _quantity;

    // Constructor
    public Product(string name, string id, float price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    // Member Functions 
    public float TotalCost()
    {
        return _price * _quantity;
    }

    public string GetName() => _name;
    public string GetId() => _id;
}
