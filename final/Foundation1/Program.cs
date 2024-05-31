using System;

class Program
{
    static void Main(string[] args)
    {
       //Creating videos
       var video1 = new Video
       {
        Title = "Techniques to improve scripture study",
        Author = "Helamã Smith",
        Length = 600
       };
       video1.Comments.Add(new Comment { Author = "Doglas", Text= "Nice tutorial."});
       video1.Comments.Add(new Comment { Author = "Benjamin", Text= "Very helpful, thanks!" });

       var video2 = new Video
       {
        Title = "Cooking Brownies",
        Author = "Jane Rodrigues",
        Length = 300
       };
       video2.Comments.Add(new Comment { Author = "Ana", Text= "Delicious recipe!"});
       video2.Comments.Add(new Comment { Author = "Mariane", Text= "I will try this today." });

       var video3 = new Video
       {
        Title = "Travel to Utah Vlog",
        Author = "Janice Kepp",
        Length = 900
       };
       video3.Comments.Add(new Comment { Author = "Ricardo", Text= "Amazing places, thanks!"});
       video3.Comments.Add(new Comment { Author = "Cassia", Text= "I hope to visit there soon." });

       // Add videos to list
       var videos = new List<Video> { video1, video2, video3};

       //Display videos info
       foreach (var video in videos)
       {
        video.DisplayVideoInfo();
       }
    }
}