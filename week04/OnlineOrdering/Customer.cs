using System.Net.Sockets;

public class Customer
{
    private string _name;
    private Address _address;

    public void set_name(string name)
    {
        _name = name;
    }
    public string get_name()
    {
        return _name;
    }
    public void set_address(Address address)
    {
        _address = address;
    }
    public Address get_address()
    {
        return _address;
    }
    public bool lives_in_usa()
    {
        return _address.is_in_usa();
    }
}