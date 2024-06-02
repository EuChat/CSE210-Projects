using System.ComponentModel.DataAnnotations;

public class Running : Activity
{
    private double  _distance;// kilometres
    public double Distance
    {
        get{return _distance; }
        private set { _distance = value;}
    }
    public Running( string date,int length,double distance) : base(date,length)
    {
        _distance = distance;
    }
    public override double GetDistance()=> distance;
    public override double GetSpeed()=> (distance/length)* 60;
    public override double GetPace()=> length /distance;

}