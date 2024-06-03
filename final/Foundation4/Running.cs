using System.ComponentModel.DataAnnotations;

public class Running : Activity
{
    public double Distance
    {
        get{return _distance; }
        private set { _distance = value;}
    }
    public Running( string date,int length,double distance) : base(date,length)
    {
        _distance = distance;
    }
    public override double GetPace()=> _length /_distance;

}