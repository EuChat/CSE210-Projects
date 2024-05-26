public class SimpleGoal: Goal
{
    private bool _isComplete = false;
    private string sign = "[ ]";
    public SimpleGoal( string name,string description,int points, bool isComplete) : base (name,description,points)
    {
        _isComplete = isComplete;
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override string GetDetailsString()
    {
        return $"{sign} {_shortName}- {_description}- {_points}points -Complete: {_isComplete}";
    }
    public override string GetStorageInfo()
    {
        return $"{sign}-{_shortName} - {_description}- {_points}-{_isComplete}";
    }

    public override string GetStringRepresentation()
    {
        return $" SimpleGoal:{_shortName}";
    }

    public override void RecordEvent()
    {
        SetIsComplete();
    }
    public void SetIsComplete()
    {
        _isComplete = true;
        sign = "[X]";
    }
}
