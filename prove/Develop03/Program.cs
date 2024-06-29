using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nWelcome to the scripture mastery program!");

        Scripture scripture = new Scripture("", "");
        Reference reference = new Reference("", 1, 1);

        int scriptureChoice = 1;
        
        do {
            Console.WriteLine("\nPick a scripture to memorize:");
            Console.WriteLine($"1. Proverbs 3:5-6");
            Console.WriteLine($"2. James 1:5-6");
            Console.WriteLine($"3. 3 Nephi 12:48");
            Console.WriteLine($"4. D&C 88:124"); 
            scriptureChoice = int.Parse(Console.ReadLine());
        } while (scriptureChoice < 1 || scriptureChoice > 4);

        if (scriptureChoice == 1) {
            reference = new Reference("Proverbs", 3, 5, 6);
            scripture = new Scripture(reference.GetScriptureReference(), "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");
        }
        else if (scriptureChoice == 2) {
            reference = new Reference("James", 1, 5, 6);
            scripture = new Scripture(reference.GetScriptureReference(), "If any of you lack wisdom, let him ask of God, that giveth to all men liberally, and upbraideth not; and it shall be given him. But let him ask in faith, nothing wavering. For he that waverth is like a wave of the sea driven with the wind and tossed.");
        }
        else if (scriptureChoice == 3) {
            reference = new Reference("3 Nephi", 12, 48);
            scripture = new Scripture(reference.GetScriptureReference(), "Therefore I would that ye should be perfect even as I, or your Father who is in heaven is perfect.");
        }
        else if (scriptureChoice == 4) {
            reference = new Reference("D&C", 88, 124);
            scripture = new Scripture(reference.GetScriptureReference(), "Cease to be idle; cease to be unclean; cease to find fault one with another; cease to sleep longer than is needful; retire to thy bed early, that ye may not be weary; arise early, that your bodies and your minds may be invigorated.");
        }
        
        string userInput = "";
        bool finished;

        do {
            finished = scripture.AllFinished();
            scripture.DisplayScripture();
            scripture.PickRandomWords();
            userInput = Console.ReadLine();
        } while (userInput.ToLower() != "q" && !finished);

    }
}