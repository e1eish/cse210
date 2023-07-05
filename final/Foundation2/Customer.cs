public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, string streetAddress, string city, string stateOrProvince, string country)
    {
        _name = name;
        _address = new Address(streetAddress, city, stateOrProvince, country);
    }

    public bool IsInUS()
    {
        return _address.IsInUS();
    }

    public string GetShippingInfo()
    {
        return $"{_name}: {_address.Display()}";
    }
}