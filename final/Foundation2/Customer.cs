public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name , Address address)
    {
        _name = name;
        _address = address;
    }

    public double IsInUSA()
    {
        double shipingCost = _address.IsInUSA()? 5.0 : 35.0;
        return shipingCost;
    }

    public string GetName()
    {
        return _name;
    }

    public string  GetAddress()
    {
        return _address.DisplayInfo();
    }
}