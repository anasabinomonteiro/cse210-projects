using System;
using System.Collections.Generic;

class Comment
{
    public string Author {get; set;}
    public string Text {get; set;}

    public void DisplayComment()
    {
        Console.WriteLine($"Comment by {Author}: {Text}");
    }
}