public class Entry()
{
    public DateTime _date = DateTime.Now;
    public string _currentPrompt;
    PromptGenerator _promptText = new PromptGenerator();
    public string _additionalNotes = "";
    public string _reply;
    public string _entryText;
    public void Display()
    {
        _currentPrompt = _promptText.GetRandomPrompt();
        Console.WriteLine(_currentPrompt);
        _entryText = Console.ReadLine();
        Console.WriteLine("Would you like to add anything else? ");
        _reply = Console.ReadLine();
        if (_reply == "yes" || _reply == "Yes")
        {
            Console.WriteLine("What will it be?");
            _additionalNotes = Console.ReadLine();

        }
    }

}