public class Address
{
    public string _street;
    public string _city;
    public string _state;
    public string _country;

    public Address (string street, string city,string state,string country)
    {
        _street= street;
        _city= city;
        _state = state;
        _country = country;
    }
    public bool IsInUSA()
    {
        if (_country.ToLower().Trim()== "usa")
        {
            return true;
        }
        else
        {
            return false;
        }
        
    }
    public string Display()
    {
        return $"{_street}, {_city}, {_state}, {_country}";
    }

}