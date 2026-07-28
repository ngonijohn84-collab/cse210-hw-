using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video(
            "Learn C# in 15 Minutes",
            "Programming Hub",
            900);

        video1.AddComment(new Comment("John", "Great tutorial!"));
        video1.AddComment(new Comment("Faith", "Very easy to understand."));
        video1.AddComment(new Comment("Kevin", "Thanks for sharing."));
        videos.Add(video1);


        Video video2 = new Video(
            "Top 10 Football Goals",
            "Sports TV",
            720);

        video2.AddComment(new Comment("Mike", "Amazing goals!"));
        video2.AddComment(new Comment("Brian", "Messi is the GOAT."));
        video2.AddComment(new Comment("Sarah", "Loved every minute."));
        videos.Add(video2);


        Video video3 = new Video(
            "Kenya Travel Guide",
            "Travel World",
            600);

        video3.AddComment(new Comment("Alice", "Beautiful places."));
        video3.AddComment(new Comment("Peter", "I want to visit Kenya."));
        video3.AddComment(new Comment("Grace", "Very informative."));
        videos.Add(video3);


        Video video4 = new Video(
            "How to Cook Pilau",
            "African Kitchen",
            540);

        video4.AddComment(new Comment("Mary", "Looks delicious."));
        video4.AddComment(new Comment("James", "Trying this today."));
        video4.AddComment(new Comment("Lucy", "Thank you for the recipe."));
        videos.Add(video4);


        foreach (Video video in videos)
        {
            video.DisplayVideo();
        }
    }
}