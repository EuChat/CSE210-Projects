public class Word
{
    private string _text;
    private bool _isHidden;
    
    public Word(string text)
    {
        _text = text;
        _isHidden= false;
    }
    public void Hide()
    {
        _isHidden = true;
    }
    
    public bool isHidden()
    {
        return _isHidden;
    }
    public string GetIsHidden()
    {
        if(_isHidden)
        {
            _text = new string('_',_text.Length);
            return _text + " ";
        }
        else
        {
            return _text +" ";
        }
    }
}