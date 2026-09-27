using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video("C# Object-Oriented Programming Tutorial", "Code Academy", 600);
        video1.AddComment(new Comment("Alice", "Great explanation of encapsulation!"));
        video1.AddComment(new Comment("Bob", "This helped me pass my coding quiz. Thanks!"));
        video1.AddComment(new Comment("Charlie", "Very clear and easy to follow."));
        videos.Add(video1);

        // Video 2
        Video video2 = new Video("Top 10 Linux Terminal Tricks", "Tech Guy", 450);
        video2.AddComment(new Comment("David", "Awesome shortcuts!"));
        video2.AddComment(new Comment("Emma", "I didn't know about the alias command. So helpful!"));
        video2.AddComment(new Comment("Frank", "Linux terminal is so powerful."));
        videos.Add(video2);

        // Video 3
        Video video3 = new Video("How to Bake Crispy Potato Chips", "Cooking Corner", 300);
        video3.AddComment(new Comment("Grace", "Tried this in my mini electric oven today! Perfect!"));
        video3.AddComment(new Comment("Hannah", "What temperature setting works best?"));
        video3.AddComment(new Comment("Ian", "Yum, making these tonight."));
        videos.Add(video3);

        // Display video details and comments
        foreach (Video video in videos)
        {
            Console.WriteLine("==================================================");
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLengthInSeconds()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($" - {comment.GetCommenterName()}: \"{comment.GetCommentText()}\"");
            }

            Console.WriteLine();
        }
    }
}