public class BreathingActivity : Activity
{
    // constructors
    public BreathingActivity(string name,string description,int duration): base (name,description,duration)
    {
        Console.WriteLine("How long do you want to take this activity?");
        string answer = Console.ReadLine();
        duration = int.Parse(answer);
        _duration = duration;
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
        while (DateTime.UtcNow <= future)
        {
            Console.Write("Breathe in ..."); ShowCountDown(5);
            Console.WriteLine("");
            Console.Write("Breathe out ..."); ShowCountDown(5);
            Console.WriteLine("");
        
        }


        DisplayEndingMessage();
    }
}