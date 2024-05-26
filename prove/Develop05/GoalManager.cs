public class GoalManager()
{
    private List<Goal> _goals  = new List<Goal>();
    private List<Goal> _readOnly  = new List<Goal>();
    public int _score;
    public void Start ()
    {
        Console.WriteLine ("Goal Manager Started.");
        using(StreamReader eyes = new StreamReader("Points.txt"))
        {
            _score = int.Parse(eyes.ReadLine());
        }
        LoadGoals(false, true);

        
    }
    public void DisplayPlayerInfor()
    {
        Console.WriteLine ($"Score:{_score}");
        ListGoalNames();
    }
    public void ListGoalNames()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetStringRepresentation());
        }
    }
    public void ListGoalDetails()
    {
        foreach(var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }

    }
    
    public void CreateGoal(Goal goal)
    {
        _goals.Add(goal);
    }
    public void RecordEvents()
    {
        Console.WriteLine("What goal did you complete?  ");
        string goal= Console.ReadLine();
        Goal goal1 = _goals.Find(x => x.GetName() == goal);
        try
        {
            
            goal1.RecordEvent();
            Complete(goal1);

            Thread.Sleep(2000);
        }
        catch (Exception)
        {
            Console.WriteLine("No goal found!\n Did you mispell it?");
        }
    }
    public void SaveGoals()
    {
        using (StreamWriter writer= new StreamWriter("Goals.txt"))
        {
            foreach (Goal goal in _goals)
            {
                writer.WriteLine($"{goal.GetStorageInfo()} |");
            }
        }
        using (StreamWriter writer= new StreamWriter("Points.txt"))
        {
            
            writer.WriteLine(_score);
        }
        Console.WriteLine("Saved!");
        Thread.Sleep(2000);
    }
    public void LoadGoals(bool show, bool first)
    {
        if (first == true)
        {
            using (StreamReader reader = new StreamReader("Goals.txt"))
            {
                // Read the stream as a string.
                string text = reader.ReadToEnd();
                if (text!="")
                {
                    string[] parts = text.Split("|");
                    foreach (string part in parts)
                    {
                        string[] info = part.Split("-");
                        info[1] = info[1].Replace("\r\n", "");
                        if (info.Length == 5)
                        {
                            _goals.Add(new SimpleGoal(info[1].Replace(@"\r\n", ""), info[2], int.Parse(info[3]), bool.Parse(info[4])));
                            _readOnly.Add(new SimpleGoal(info[1].Replace(@"\r\n", ""), info[2], int.Parse(info[3]), bool.Parse(info[4])));
                        }
                        else if (info.Length == 7)
                        {
                            _goals.Add(new ChecklistGoal(info[1].Replace(@"\r\n", ""), info[2], int.Parse(info[3]), int.Parse(info[4]), int.Parse(info[5]), int.Parse(info[6])));
                            _readOnly.Add(new ChecklistGoal(info[1].Replace(@"\r\n", ""), info[2], int.Parse(info[3]), int.Parse(info[4]), int.Parse(info[5]), int.Parse(info[6])));
                        }
                        else if (info.Length == 3)
                        {
                            _goals.Add(new EternalGoal(info[1].Replace(@"\r\n", ""), info[2], int.Parse(info[3])));
                            _readOnly.Add(new EternalGoal(info[1].Replace(@"\r\n", ""), info[2], int.Parse(info[3])));
                        }
                    }
                }
            }
        }
        
            // Write the text to the console.
            if (show == true)
            {
                foreach (Goal item in _readOnly)
                {
                    Console.WriteLine(item.GetDetailsString());
                }
            }
            
            Thread.Sleep(2000);
        
    }
    public int GetScore()
    {
        return _score;
    }

    public void Complete(Goal goal)
    {
        if (goal.IsComplete() == true)
        {
            _score += goal.GetPoints();
        }
        if (goal.GetType()==typeof(EternalGoal) || goal.GetType()==typeof(ChecklistGoal) )
        {
            _score += goal.GetPoints();
            // _score += goal.GetBonus();
        }
        
        SaveGoals();
        Console.WriteLine("Congratulations, You have made an achievement");
        

    }
}