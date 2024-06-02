public class Comment
{
    public string _nameOfPerson;
    public string _text;
    public Comment(string name, string text)
    {
        _nameOfPerson = name;
        _text = text;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"{_nameOfPerson}\t:{_text}");
    }
}