using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nWelcome to the journal program.");
        Console.WriteLine("\nPlease pick an option:");
        Console.WriteLine();

        int userChoice;

        do {
            Menu menu = new Menu();
            menu.DisplayOptions();
            Console.Write("What would you like to do? ");
            userChoice = int.Parse(Console.ReadLine());
        } while (userChoice != 5);


        }
}