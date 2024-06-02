public class OutdoorGathering
{
    private string _weatherForecast;
    public string WeatherForecast
    {
        get{return _weatherForecast; }
        private set{_weatherForecast = value;}
    }
    public OutdoorGathering( string title,string description,string date,string time,Address address,string weatherForecast,) :base(title,description,date,time,address)
    {
        WeatherForecast=weatherForecast;
    }
    
    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nType:OutDoor Gathering\nWeather:{WeatherForecast}";
    }
    public override string GetShortDescription ()
    {
        return $"Outdoor Gathering: {Title}\nDate: {Date} ";
    
}