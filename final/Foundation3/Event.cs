using System.Dynamic;

public class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private  Address EventAddress;
    protected string Title
    {
        get{return _title;}
        set { _title= value;}
    }
    protected string Description
    {
        get{return _description;}
        set {_description =value;}
    }
    protected string Time
    {
        get{return _time;}
        set{_time = value;}
    }
    protected string Date
    {
        get{return _date;}
        set{_date = value;}
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