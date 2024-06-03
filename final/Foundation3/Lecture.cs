public class Lecture : Event
{
    private string _speaker;
    private int _capacity;
    public string Speaker
    {
        get { return _speaker;}
        private set { _speaker = value;}
    }
    public int Capacity
    {
        get { return _capacity;}
        set {_capacity = value;}
    }

    public Lecture( string title,string description,string date,string time,Address address,string speaker,int capacity) : base (title,description,date,time,address)
    {
        Speaker = speaker;
        _capacity = capacity;
    }
    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nType:Lecture\nSpeaker:{Speaker}\n_capacity: {_capacity}";
    }
    public override string GetShortDescription ()
    {
        return $"Lecture: {Title}\nDate: {Date} ";
    }
}