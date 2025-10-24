using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Learning C#", "Charity Becker", 600);
        video1.AddComment(new Comment("John", "This was really helpful!"));
        video1.AddComment(new Comment("Sarah", "Loved your explanation."));
        video1.AddComment(new Comment("Alex", "Very clear and easy to folow."));
        videos.Add(video1);

        Video video2 = new Video("Intro to Networking", "Luis Meraz", 480);
        video2.AddComment(new Comment("Daniel", "Thanks for breaking it down."));
        video2.AddComment(new Comment("Nina", "Super useful for beginners."));
        video2.AddComment(new Comment("Patti", "I finally get it now!"));
        videos.Add(video2);

        Video video3 = new Video("Understanding Firewalls", "Gary Frazier", 720);
        video3.AddComment(new Comment("Kenai", "Great visuals!"));
        video3.AddComment(new Comment("Mitchell", "Clear and concise."));
        video3.AddComment(new Comment("Rachael", "Thanks for the security tips."));
        videos.Add(video3);

        Video video4 = new Video("Setting Up UniFi Networks", "Joey Ozment", 900);
        video4.AddComment(new Comment("Sergio", "I used this to fix my setup."));
        video4.AddComment(new Comment("Mason", "Very detailed guide."));
        video4.AddComment(new Comment("Mary", "You made this simple!"));
        videos.Add(video4);

        foreach(Video video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}