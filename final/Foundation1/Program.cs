using System;

class Program
{
    static void Main(string[] args)
    {
        Comment comment1 = new Comment("Sally", "This is the best pie I've ever made!");
        Comment comment2 = new Comment("Bobby", "This is a good recipe but I wish it had more cherries.");
        Comment comment3 = new Comment("Terry", "The instructions were too hard to follow.");
        Video video1 = new Video("How to bake cherry pie", "Cooking with Tara", 931.21);
        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);
        video1.DisplayVideoInfo();
        video1.DisplayComments();
        Console.WriteLine();

        Comment comment4 = new Comment("Mollie", "You're so relatable!");
        Comment comment5 = new Comment("Emma", "Where did you get your backpack?");
        Comment comment6 = new Comment("Daniel", "This girl is so annoying");
        Video video2 = new Video("Day in my life as a college student", "Callie Cay", 1800.45);
        video2.AddComment(comment4);
        video2.AddComment(comment5);
        video2.AddComment(comment6);
        video2.DisplayVideoInfo();
        video2.DisplayComments();
        Console.WriteLine();

        Comment comment7 = new Comment("Aubrey", "Taking my AP exam tomorrow!! This was so helpful!");
        Comment comment8 = new Comment("Cole", "This is stupid. Why make a whole video of AP Calc? It's super easy");
        Comment comment9 = new Comment("Nate", "lol i don't know why i watched this i took ap calc 5 years ago");
        Video video3 = new Video("QUICK RECAP OF ALL OF AP CALCULUS", "Math with Bob", 3409.20);
        video3.AddComment(comment7);
        video3.AddComment(comment8);
        video3.AddComment(comment9);
        video3.DisplayVideoInfo();
        video3.DisplayComments();
    }
}