using System;
using System.Collections.Generic;

class Video
{
    public string Title {get; set;}
    public string Author {get; set;}
    public int Length {get; set;}
    public List<Comment> Comments {get; set;} = new List<Comment>();

    public int GetCommentCount()
    {
        return Comments.Count;
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Length: {Length} seconds");
        Console.WriteLine($"Number of Comments: {GetCommentCount()}");
        Console.WriteLine($"Comments:");
        foreach (var comment in Comments)
        {
            comment.DisplayComment();
        }

        Console.WriteLine();
    }
}
