// using System.ComponentModel.DataAnnotations;
// using System.Security.Cryptography;

public abstract class Activity
{
    protected string _date;
    protected double  _distance;// kilometres
    protected int _length ;// in minutes
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
    public virtual double GetDistance()
    {
        return _distance;
    } // in kilometers
    public virtual double GetSpeed()
    {
        return _distance/_length* 60;
    }// in kph
    public abstract double GetPace(); // in minutes per kilometer
    
    public string GetSummary()
    {
        return $"{Date}({Length}min):Distance: {GetDistance(): 0.0}km, Speed:{GetSpeed():0.0}km/h,Pace:{GetPace():0.0}min/kilometer";
    }
}