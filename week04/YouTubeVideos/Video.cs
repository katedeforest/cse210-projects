using System;
using System.IO;
using System.Collections.Generic;

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

    public void AddComment(Comment newComment)
    {
        _comments.Add(newComment);
    }
    public int CommentNumber()
    {
        int count = 0;
        foreach (Comment comment in _comments)
        {
            count += 1;
        }
        return count;
    }
    public void GetDisplayText()
    {
        Console.WriteLine("–––––––––––––––––––––––––");

        TimeSpan time = TimeSpan.FromSeconds(_length);
        string formatMinutesSeconds = time.ToString(@"mm\:ss");

        Console.WriteLine($"TITLE: {_title}\nAUTHOR: {_author}\nLENGTH: {formatMinutesSeconds}");
        
        foreach (Comment comment in _comments)
        {
            comment.GetDisplayText();
        }

        Console.WriteLine("–––––––––––––––––––––––––");
    }
}