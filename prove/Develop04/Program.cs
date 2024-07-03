using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop04 World!");
        // Console.WriteLine("Going to sleep for a second...");
        // Thread.Sleep(1000);
        // Console.WriteLine("I'm back!");

        // // spinning animation
        // for (int i = 0; i < 5; i++) {
        // Console.Write("-");
        // Thread.Sleep(500);
        // Console.Write("\b \b");
        // Console.Write("\\");
        // Thread.Sleep(500);
        // Console.Write("\b \b");
        // Console.Write("|");
        // Thread.Sleep(500);
        // Console.Write("\b \b");
        // Console.Write("/");
        // Thread.Sleep(500);
        // Console.Write("\b \b");
        // }
        // Console.WriteLine("Spinner Done.");
        // Thread.Sleep(1000);
        // Console.Write("This will be a countdown... 3");
        // Thread.Sleep(1000);
        // Console.Write("\b \b");
        // Console.Write("2");
        // Thread.Sleep(1000);
        // Console.Write("\b \b");
        // Console.Write("1");
        // Thread.Sleep(1000);
        // Console.Write("\b \b");
        // Console.Write("0");
        // Thread.Sleep(500);

        Console.WriteLine("Welcome to the breathing activity!!");
        Thread.Sleep(2000);
        BreathingActivity breaths = new BreathingActivity("la", "la");
        breaths.RunActivity();
    }
}