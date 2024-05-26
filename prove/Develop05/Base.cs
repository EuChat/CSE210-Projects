public class Base()
{
    private string _name;
    private string _description;
    private int _points;
    private int _target;
    private int _bonus;

    public void Questions()
    {
        Console.WriteLine("What is the name of your goal?");
        _name = Console.ReadLine().Trim();
    
        Console.WriteLine("Give a short discription of your goal.");
        _description = Console.ReadLine();

        Console.WriteLine("What is the amount if points associated with this goal?");
        _points = int.Parse(Console.ReadLine());
    }
    public void Target()
    {
        Console.WriteLine("What is the target associated with this goal?");
        _target = int.Parse(Console.ReadLine());

        Console.WriteLine("What is the bonus associated with this goal?");
        _bonus = int.Parse(Console.ReadLine());
    }
    public string GetName()
    {
        return _name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public int GetPoints()
    {
        return _points;
    }
    public int GetTarget()
    {
        return _target;
    }
    public int GetBonus()
    {
        return _bonus;
    }
}