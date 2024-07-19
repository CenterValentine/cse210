using System;

public class Video
{
    private string _title;
    private string _author;
    // length of video in seconds
    private int _length;

    private List<Comment> _comments = new List<Comment>();

    public void AddComment(Comment newComment)
    {
        _comments.Add(newComment);
    }

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public string GetVideo()
    {
        // video object
        return $"{_title}, {_author}, {_length}";
    }

    public int NumberOfComments()
    {
        int numberOfComments = 0;
        foreach (Comment comment in _comments)
        {
            numberOfComments++;
        }
        return numberOfComments;
    }

    public void DisplayVideo()
    {
        Console.WriteLine($"Video: {_title} by {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine($"Number of comments: {NumberOfComments()}\n");
        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
        }
        Console.WriteLine();
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine();
    }

}