public  class Cycling : Activity
{
    private double _speed;// in kph
    
    public Cycling(string date,int length,double speed, double distance): base (date,length)
    {
        _speed = speed;
        _distance = distance;
    }
    public double Speed
    {
        get{ return _speed; }
        private set { _speed = value;}
    }
    public override double GetPace()=>60/ _speed;
    public override double GetDistance()=>60*_speed;
}