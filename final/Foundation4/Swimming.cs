using System.ComponentModel.DataAnnotations;

public class Swimming  : Activity
{
    private int _laps;
    public int Laps
    {
        get { return _laps; }
        private set { _laps = value;}
    }
    public Swimming(string date,int length,int laps): base (date,length)
    {
        Laps= laps;
    }
    public override double GetDistance()=> Laps* 50/1000.0 * 0.62;
    public override double GetSpeed()=> (GetDistance() /Length)* 60;
    public override double GetPace()=> Length / GetDistance();
    
}