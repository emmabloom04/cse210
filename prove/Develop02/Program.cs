using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the journal program.");
        Console.WriteLine("Please pick an option:");
        Menu menu = new Menu();
        menu.DisplayOptions();
    }
}