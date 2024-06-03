public class Reception: Event
{
    private string _RSVPEmail;
    
    public Reception( string title,string description,string date,string time,Address address,string RSVPEmail) :base (title,description,date,time,address)
    {
        _RSVPEmail = RSVPEmail;
    }
    public override string GetFullDetails ()
    {
        return GetStandardDetails()+ $"\nRSVP: {RSVPEmail}";
    }
    public string RSVPEmail
    {
        get{ return _RSVPEmail; }
        private set { _RSVPEmail = value;}
    } 
}