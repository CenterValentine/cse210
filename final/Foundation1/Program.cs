using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Video video1 = new Video("Cat Video", "Mr. One", 100);
        video1.AddComment(new Comment("Adorable!", "Randy Dom"));
        video1.AddComment(new Comment("I'm never wearing a sweater again!", "Mr. Rogers"));
        video1.AddComment(new Comment("I want that cat!", "Mr. E."));
        video1.AddComment(new Comment("I saw that coming from a mile away!", "Ms. Scope"));
        Video video2 = new Video("Dog Video", "Ms. Two", 200);
        video2.AddComment(new Comment("This is why I'm never getting a dog", "Ms. Cat"));
        video2.AddComment(new Comment("I'm getting a dog!", "Ms. Dog"));
        video2.AddComment(new Comment("If my dog ate my sandwich, he'd sleep with the chickens", "Ms. Farmer"));
        video2.AddComment(new Comment("Adorable!", "Cat Lady"));
        Video video3 = new Video("DIY Video", "Handy Man", 300);
        video3.AddComment(new Comment("I'm never doing that!", "Ms. Lazy"));
        video3.AddComment(new Comment("I'm doing that!", "Mr. Eager"));
        video3.AddComment(new Comment("He makes it look so easy!", "Noah Way"));
        video3.AddComment(new Comment("I do this all the time!", "Noah Brainer"));
        Video video4 = new Video("Baby Video", "Mr. Four", 400);
        video4.AddComment(new Comment("jdOxyddhchsahh aaaa", "Baby"));
        video4.AddComment(new Comment("I can't understand a word he's saying", "Miss Translator"));
        video4.AddComment(new Comment("I can't help but smile", "Mr. Grumpy"));
        video4.AddComment(new Comment("But I can't help but falling in love with you", "Mrs. Presley"));

        List<Video> videos = new List<Video> { video1, video2, video3, video4 };
        foreach (Video video in videos)
        {
            video.DisplayVideo();
        }

    }
}