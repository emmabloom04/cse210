using System;

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address("1234 Cherry Ln", "Rexburg", "ID", 83440, "US");
        
        OutdoorGathering outdoorGathering = new OutdoorGathering("Birthday party", "Fun party with all of my friends for my 20th birthday", "April 26, 2025", "6:00-8:00pm", address, "Sunny with slight chance of rain");
        outdoorGathering.DisplayInfo();
        Console.WriteLine();

        Reception reception = new Reception("Wedding reception", "A reception celebrating the wedding of David and Sarah", "July 14, 2022", "5:00-9:00pm", address, "someonesemail@gmail.com");
        reception.DisplayInfo();
        Console.WriteLine();

        Lecture lecture = new Lecture("Lecture on how to have a good career", "Advice will be given at this lecture on how to jumpstart your career and improve your resume.", "August 4, 2024", "2:00-4:00pm", address, "Billy Bob", 50);
        lecture.DisplayInfo();
    }
}