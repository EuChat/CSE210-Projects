public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;
    public string street
    {
        get{return _street;}
        private set{_street= value;}
    }
    public string city
    {
        get{return _city;}
        private set{_city =value;}
    }
    public string state
    {
        get{return _state;}
        private set{_state =value;}
    }
    public string country
    {
        get{return _country;}
        private set{_country=value;}
    }

         

    public Address(string street,string city,string state,string country)
    {
        _street =street;
        _city= city;
        _state =state;
        _country =country;
    }
    public override string ToString()
    {
        return $"{street},{city},{state},{country}";
    }

}