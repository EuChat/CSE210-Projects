public class ListingActivity : Activity
{
    private List<string> _promptListToBeUsed;    

    private int _count;
    private List<string> _answers = new List<string>();
    private List<string> _usedPrompts = new List<string>();
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    // constructors
    public ListingActivity(string name,string description,int duration,int count): base (name,description,duration)
    {
        Console.WriteLine("How long do you want to take this activity?");
        string answer = Console.ReadLine();
        duration = int.Parse(answer);
        _duration = duration;
        _count = count;
    }
    public void Run()
    {
        Console.Clear();
        Console.WriteLine("Loading...\n");
        ShowSpinner(5);
        Console.Clear();
        DisplayStartingMessage();
        Thread.Sleep(4000);
        
        DateTime current = DateTime.UtcNow;
        DateTime future = current.AddSeconds(_duration);

        Console.WriteLine(GetRandomPrompt());
        while (DateTime.UtcNow <= future)
        {
            string line  = Console.ReadLine();
            _count ++;
            _answers.Add(line);
        }
        
        Console.WriteLine($"Time's up, Here is what you have done.");
        foreach (string item in _answers)
        {
            Console.WriteLine(item);
            Thread.Sleep(500);
        }

        Console.WriteLine($"Total: {_count}");
        
        
        DisplayEndingMessage();
    }
    public string GetRandomPrompt()
    {
        _promptListToBeUsed = _prompts;
        if (_prompts.Count == 0)
        {
            _promptListToBeUsed = _usedPrompts;
        }
        Random random = new Random();
        string propmt = _promptListToBeUsed[random.Next(0, _promptListToBeUsed.Count)];
        _usedPrompts.Add(propmt);
        _prompts.Remove(propmt);
        return propmt;
    }
    public List<string>GetListFromUser()
    {
        return new List<string>();
    }
}