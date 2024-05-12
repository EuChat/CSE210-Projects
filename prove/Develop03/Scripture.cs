using System.Collections;

public class Scripture
{
    private Reference _reference;
    Random randomizer = new Random();
    private List<Word> _words= new List<Word>();
    private List<int> _Hidden = new List<int>();
    public Scripture(Reference reference) 
    {
        _reference=reference;
        string[] words = reference.GetText().Split(" ");
        foreach (string word in words)
        {
            _words.Add (new Word (word));
        }
        for (int i = 0; i < _words.Count; i++)
        {
            _Hidden.Add(i);
        }



    }
    public void HideRandomWords()
    {
        for (int i= 0; i<2; i++)
        {
            int index;
            
            Word randomWord = _words.OrderBy(s => randomizer.NextDouble()).First();
            index = _words.IndexOf(randomWord);            
            _words[index].Hide();
            _words[index].GetIsHidden();
            
            _Hidden.Remove(index);

        }
    }

    public string GetDisplayText()
    {
        _reference.GetDisplayText();

        foreach(Word word in _words)
        {
            Console.Write(word.GetIsHidden());
        }
        
        
        return " ";
    }

    public bool IsCompletelyHidden()
    {
        bool run;
        if (GetHidden()== 0)
        {
            Console.WriteLine("\n Done");
            run = true;
        }
        else
        {
            run = false;
        }
        return run;
    }
    public int GetHidden()
    {
        return _Hidden.Count;
    }
}
