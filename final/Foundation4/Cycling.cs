public  class Cycling : Activity
{
    private double _speed;// in kph
    public double Speed
    {
        get{ return _speed; }
        private set { _speed = value;}
    }
    public  Cycling(string date,int length,double Speed): base (date,length);
    {
        _Speed = speed;
    }
    public override double GetSpeed()=> speed;
    public override double GetPace()=>60/speed;
}