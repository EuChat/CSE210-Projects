public class WritingAssignment : Assignment
{
    private string _textbookSection;
    private string _description;
    private string _problems;
    public WritingAssignment(string studentName, string topic, string textbookSection, string description) :base (studentName,topic)
    {
        _textbookSection = textbookSection;
        _description = description;
    }
    public string GetWritingInformation()
    {
        Console.WriteLine($"{GetStudentName()},{ _textbookSection}\n {_description}");
        return _description;
    }
}