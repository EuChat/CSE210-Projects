using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;

public abstract class Activity
{
    private string _date;
    private int _length ;// in minutes
    public string Date
    {
        get{return _date; }
        private set{_date = value;}

    }
    public int Length
    {
        get{return _length;}
        private set{_length =value;}
    }
    
    public Activity(string date,int length)
    {
        _date = date;
        _length = length;
    }
    public abstract double GetDistance(); // in kilometers
    public abstract double GetSpeed();// in kph
    public abstract double GetPace(); int // in minutes per kilometer

    public virtual string GetSummary()
    {
        return $"{Date}({length}min):Distance: {GetDistance(): 0.0}miles, Speed:{GetSpeed():0.0}kph,Pace:{GetPace():0.0}min/kilometer";
    }

}