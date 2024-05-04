public class Journal()
{
    List<Entry>  _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine($"{entry._date}\n {entry._currentPrompt}\n {entry._entryText}\n {entry._additionalNotes}|\n ");
        }
    }

    public void SaveToFile()
    {
        Console.WriteLine("What file would you like to save it to?");
        string file = Console.ReadLine();
        if (!File.Exists(file))
        {
            using (StreamWriter outputfile = new StreamWriter(file))
            {
                foreach(Entry entry in _entries)
                {
                    outputfile.WriteLine($"{entry._date}\n {entry._currentPrompt}\n {entry._entryText}\n {entry._additionalNotes}|\n ");
                }
            }
        }
        else
        {
            using(var writer = File.AppendText(file))
            {
                foreach(Entry entry in _entries)
                {
                    writer.WriteLine($"{entry._date}\n {entry._currentPrompt}\n {entry._entryText}\n {entry._additionalNotes}|\n ");
                }
            }
            //Kill duplicates
            File.WriteAllLines(file, File.ReadAllLines(file).Distinct().ToArray());

        }
    }
    public void LoadFromFile()
    {
        Console.WriteLine("What file would you like to load?");
        string file = Console.ReadLine();
        try
        {
            string[] _lines = File.ReadAllLines(file);

            foreach (string line in _lines)
            {
                Console.WriteLine(line);            
            }
        }
        catch (Exception)
        {
            Console.WriteLine("File does not exist(try including file extention name)");
        }
        
        
    }

}
