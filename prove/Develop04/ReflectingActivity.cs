public class ReflectingActivity : Activity
{
    private List<string> _usedPrompts= new List<string>();
    private List<string> _usedQuestions= new List<string>();
    private List<string> _prompts= new List<string>()
    {
    "Think of a time when you stood up for someone else.",
    "Think of a time when you did something really difficult.",
    "Think of a time when you helped someone in need.",
    "Think of a time when you did something truly selfless.",
    };
    private List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    // constructors
    private List<string> _questionListToBeUsed;    
    private List<string> _promptListToBeUsed;    


    public ReflectingActivity(string name, string description, int duration): base (name,description,duration)
    {
        Console.WriteLine("How long do you want to take this activity?");
        string answer = Console.ReadLine();
        duration = int.Parse(answer);
        _duration = duration;
    }

    public void Run ()
    {
        Console.Clear();
        Console.WriteLine("Loading...\n");
        ShowSpinner(5);
        Console.Clear();
        DisplayStartingMessage();
        Thread.Sleep(4000);

        DateTime current = DateTime.UtcNow;
        DateTime future = current.AddSeconds(_duration);

        DisplayPrompt();
        ShowSpinner(10);

        while (DateTime.UtcNow <= future)
        {
            DisplayQuestions();
            ShowSpinner(10); 
        }
        
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
    public string GetRandomQuestion ()
    {
        _questionListToBeUsed = _questions;
        if (_questions.Count == 0)
        {
            _questionListToBeUsed = _usedQuestions;
        }
        Random random = new Random();
        string question = _questionListToBeUsed[random.Next(0, _questionListToBeUsed.Count)];
        _usedQuestions.Add(question);
        _questions.Remove(question);
        
        return question;
    }
    public void DisplayPrompt ()
    {
        Console.WriteLine(GetRandomPrompt());
    }
    public void DisplayQuestions()
    {
        Console.WriteLine(GetRandomQuestion());

    }
}