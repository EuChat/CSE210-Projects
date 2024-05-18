public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    // constructor for the activity class
    public Activity( string name,string description,int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    } 

    //methods
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"{_name}\n{_description}\nDuration {_duration}s");
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Good Job");
        Thread.Sleep(1000);
        Console.WriteLine($"You have completed the {_name}");
        Thread.Sleep(1000);
        Console.WriteLine($"Duration: {_duration}s");

    }
    public void ShowSpinner(int seconds)
    {
        DateTime currentTime = DateTime.Now;
        DateTime future = currentTime.AddSeconds(seconds);

        int index = 0;
        List<string> icons = new List<string>()
        {"|", "/", "-", "\\"};   
        while(DateTime.Now <= future)
        {
            Console.Write(icons[index]);
            Thread.Sleep(500);
            Console.Write("\b \b");
            index++;

            if (index>= icons.Count)
            {
                index = 0;
            }
        }
        
    }
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i >0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}