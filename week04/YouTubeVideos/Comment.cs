using System;
using System.IO;
using System.Collections.Generic;

public class Comment
{
    private string _viewer;
    private string _text;

    public Comment(string viewer, string text)
    {
        _viewer = viewer;
        _text = text;
    }

    public void GetDisplayText()
    {
        Console.WriteLine($"\nVIEWER: @{_viewer}\nCOMMENT: {_text}");
    }
}