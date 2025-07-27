public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;
    
    public string get_street()
    {
        return _street;
    }
    public string get_city()
    {
        return _city;
    }
    public string get_state()
    {
        return _state;
    }
    public string get_country()
    {
        return _country;
    }
    public void set_country(string country)
    {
        _country = country;
    }
public void set_address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }
    public bool is_in_usa()
    {
        if (string.IsNullOrEmpty(_country))
        {
            return false;
        }
        return _country.ToLower() == "usa" || _country == "united states" || _country == "united states of america";
    }
    public string get_full_address()
    {
        return $"{_street}, {_city}, {_state}, {_country}";
    }
    
}