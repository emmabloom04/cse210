using System;
using System.Security.AccessControl;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        Resume resume = new Resume();
        string addMoreJobs = "yes";
        Console.WriteLine("Welcome to the resume creator.");
        string member = resume.GetMemberName();
        do {
            resume.AddJobs();
            Console.Write("Would you like to add another job? (yes or no) ");
            addMoreJobs = Console.ReadLine();
        } while (addMoreJobs.ToLower() == "yes");
        resume.Display();
    }
}