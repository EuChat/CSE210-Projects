using System.Dynamic;

public class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private  Address EventAddress;
    private string Title
    {
        get{return _title;}
        private set { _title= value;}
    }
    private string Description
    {
        get{return _description;}
        private set {_description =value;}
    }
    private string Time
    {
        get{return _time;}
        private set{_time = value;}
    }
    public Event( string title,string description,string date, string time,Address address)
    {
        _title = title;
        _description = description;
        _date =date;
        _time =time;
        EventAddress =address;
    }
    public virtual string GetStandardDetails ()
    {
        return $"{Title}\n{Description}\nDate: {Date}\nTime:{Time}\nAddress:{EventAddress}";
    }
    public virtual string GetFullDetails()
    {
        return GetStandardDetails ();
    }
    public virtual string GetShortDescription()
    {
        return $"Event:{Title}\nDate:{Date}";
    }
}