public class Lecture
{
    private string _speaker;
    private int Capacity;
    public string Speaker
    {
        get { return _speaker;}
        private set { _speaker = value;}
    }
    public int Capacity
    {
        get { return _capacity;}
        private set {_capacity = value;}
    }

    public Lecture( string title,string description,string date,string time,Address address,string speaker,int capacity) : base (title,description,date,time,address)
    {
        Speaker = speaker;
        Capacity = capacity;
    }
    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nType:Lecture\nSpeaker:{Speaker}\nCapacity: {Capacity}";
    }
    public override string GetShortDescription ()
    {
        return $"Lecture: {Title}\nDate: {Date} ";
    }
}