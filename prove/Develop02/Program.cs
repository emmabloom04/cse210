using System;
using System.Runtime.InteropServices;

class Program
{

    static void Main(string[] args)
    
    {
        List<Entry> entries = new List<Entry>();
        Journal journal = new Journal();
        Console.WriteLine("\nWelcome to the journal program.");
        Console.WriteLine("\nPlease pick an option:");

        int userChoice;

        do {
            Menu menu = new Menu();
            menu.DisplayOptions();
            Console.Write("What would you like to do? ");
            userChoice = int.Parse(Console.ReadLine());

            if (userChoice == 1) {
                Entry entry = new Entry();
                entry.GetDate();
                entry.GetResponse();
                entries = journal.AddEntry(entry); 
            }
            else if (userChoice == 2) {
                journal.Display();
            }
            else if (userChoice == 3) {
                Console.Write("Please enter the file name: ");
                string filename = Console.ReadLine();
                journal.ReadFromFile(filename);
            }
            else if (userChoice == 4) {
                Console.Write("Pleae enter the file name: ");
                string filename = Console.ReadLine();
                journal.WriteToFile(filename);
            }
        } while (userChoice != 5);

        }
}