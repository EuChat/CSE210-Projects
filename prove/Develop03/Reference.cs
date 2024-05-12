public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;
    private string _text;
    private bool _multiple;
    public Reference(string book, int chapter, int verse, string words)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse= verse;
        _text = words;
        _multiple = false;
    }
    public Reference(string book, int chapter, int startVerse,int endVerse, string words)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
        _text = words;
        _multiple = true;

    }
    
    public string GetDisplayText()
    {
        if (!_multiple)
        {
            Console.WriteLine($"{_book} {_chapter}: {_verse}");
        }
        else if (_multiple)
        {
            Console.WriteLine($"{_book} {_chapter}: {_verse} - {_endVerse}");
        }
        return _book ;
    }
    
    public string GetText()
    {
        return _text;
    }
    
}