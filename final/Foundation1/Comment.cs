
using System;
using System.ComponentModel.DataAnnotations;

public class Comment
{
    private string _commenter;
    private string _comment;

    public Comment(string comment, string commenter)
    {
        _commenter = commenter;
        _comment = comment;
    }

    public void DisplayComment()
    {
        Console.WriteLine($"{_commenter}: {_comment}");
    }

}