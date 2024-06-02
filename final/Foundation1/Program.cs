using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        
        Video video1 = new Video("Earth", "One man army", 4500);
        video1.AddComment(new Comment("Feathers", "Beautiful"));
        video1.AddComment(new Comment("Living Darkness", "Fantastic"));
        video1.AddComment(new Comment("Thin man", "Stupendous"));

        Video video2 = new Video("Space net", "Sunny cloud", 6700);
        video2.AddComment(new Comment("Wilbur", "Wonderful"));
        video2.AddComment(new Comment("Tommy", "I love what he did with the telescpoe"));
        video2.AddComment(new Comment("One man army", "I will never see space the same again"));
        video2.AddComment(new Comment("New guy", "I liked my own comment"));
        
        Video video3 = new Video("Daily blog", "Thin man", 980);
        video3.AddComment(new Comment("Scary shadows", "Too short"));
        video3.AddComment(new Comment("Rosey", "I need more videos"));
        video3.AddComment(new Comment("Bob", "I can relate to that"));
        
        Video video4 = new Video("Closed connections", "Scary shadows", 5620);
        video4.AddComment(new Comment("Sunny cloud", "He is legend"));
        video4.AddComment(new Comment("John", "Raise your hand if you have been watching Scary shadows for a long time"));
        video4.AddComment(new Comment("Robert", "He does it again"));
        video4.AddComment(new Comment("Harry", "Anyone saw the cat?"));

        List<Video> videos = new List<Video>
        {
            video1,
            video2,
            video3,
            video4
        };

        foreach (Video video in videos)
        {
            video.DisplayInfo();
            Console.WriteLine("");
        }
        
    }
}