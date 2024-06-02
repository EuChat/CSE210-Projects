public class Reception: Event
{
    private string RSVPEmail;
    public string RSVPEmail
    {
        get{ return _rsvpEmail; }
        private set { _rsvpEmail = value;}
    } 
    public Reception( string title,string description,string date,string time,Address address,string rsvpEmail) :base (title,description,date,time,address)
    {
        RSVPEmail = rsvpEmail;
    }
    public override string GetFullDetails ()
    {
        return $"Reception:{Title}\nDate: {Date}";
    }
}