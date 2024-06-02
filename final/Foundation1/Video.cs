public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string Author, int length)
    {
        _title = title;
        _author = Author;
        _length = length;
    }
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Title\t:{_title}\nAuthor\t:{_author}\nLength\t:{_length} sec\nComment\t:{_comments.Count} coments");
        foreach (Comment comment in _comments)
        {
            comment.DisplayInfo();
        }
    }
}