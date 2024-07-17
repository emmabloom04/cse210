using System;

class Program
{
    static void Main(string[] args)
    {
        Comment comment1 = new Comment("Person", "Comment");
        Comment comment2 = new Comment("Person", "Comment");
        Comment comment3 = new Comment("Person", "Comment");
        Video video1 = new Video("Title", "Author", 6.78);
        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);
        video1.DisplayVideoInfo();
        video1.DisplayComments();
        Console.WriteLine();

        Comment comment4 = new Comment("Person", "Comment");
        Comment comment5 = new Comment("Person", "Comment");
        Comment comment6 = new Comment("Person", "Comment");
        Video video2 = new Video("Title", "Author", 345.2);
        video2.AddComment(comment4);
        video2.AddComment(comment5);
        video2.AddComment(comment6);
        video2.DisplayVideoInfo();
        video2.DisplayComments();
        Console.WriteLine();

        Comment comment7 = new Comment("Person", "Comment");
        Comment comment8 = new Comment("Person", "Comment");
        Comment comment9 = new Comment("Person", "Comment");
        Video video3 = new Video("Title", "Author", 34.734);
        video3.AddComment(comment7);
        video3.AddComment(comment8);
        video3.AddComment(comment9);
        video3.DisplayVideoInfo();
        video3.DisplayComments();
    }
}