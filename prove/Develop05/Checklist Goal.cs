public class ChecklistGoal : Goal
{
    private bool _isComplete = false;
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    private string sign = "[ ]";

    public ChecklistGoal(string name,string description, int points,int target,int bonus) :base(name,description,points)
    {
        _target =target;
        _bonus = bonus;
    }
    public ChecklistGoal(string name,string description, int points,int amountCompleted, int target,int bonus) :base(name,description,points)
    {
        _bonus = bonus;
        _amountCompleted =amountCompleted;
        _target =target;
    }

    public override void RecordEvent ()
    {
        _amountCompleted ++;
        if (GetAmountCompleted() == GetTarget())
        {
            SetIsComplete();
        }
    }
    public override string GetDetailsString()
    {
        return $" {sign} {_shortName}: {_description}-Points: { _points}- Progress:{_amountCompleted}/ {_target}-Bonus:{_bonus}";
    } 
    public override string GetStorageInfo()
    {
        return $"{sign} -{_shortName}- {_description} - { _points} - {_amountCompleted}- {_target} - {_bonus}";
    }
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_shortName}";
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }
    public void SetIsComplete()
    {
        _isComplete = true;
        sign = "[X]";
    }
    public int GetTarget()
    {
        return _target;
    }
    
    public int GetAmountCompleted()
    {
        return _amountCompleted;
    }
    public int GetBonus()
    {
        return _bonus;
    }

    
}