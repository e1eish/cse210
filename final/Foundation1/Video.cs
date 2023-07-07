public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public Video(string title, string author, int length, List<Comment> comments)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = comments;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public void Display()
    {
        Console.WriteLine($"{_title}\n{_author} - {_length} seconds");
        Console.WriteLine();
        Console.WriteLine($"{_comments.Count} comments");
        foreach (Comment comment in _comments)
        {
            Console.WriteLine(comment.Display());
        }
    }
}