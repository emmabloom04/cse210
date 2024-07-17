class Video
{
    private string _title;
    private string _author;
    private double _lengthOfVideo;
    private List<Comment> _comments = new List<Comment>();
    public Video(string title, string author, double lengthOfVideo)
    {
        _title = title;
        _author = author;
        _lengthOfVideo = lengthOfVideo;
    }

    public int GetListLength()
    {
        return _comments.Count;
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Video title: {_title}\nVideo Author: {_author}\nVideo Length: {_lengthOfVideo} seconds\nComments: {GetListLength()}");
    }

    public void DisplayComments()
    {
        Console.WriteLine();
        Console.WriteLine($"Comments:");

        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
        }
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
}