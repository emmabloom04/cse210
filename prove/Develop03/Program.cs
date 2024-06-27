using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the scripture mastery program!");

        Reference sr1 = new Reference("Proverbs", 3, 5, 6);
        Reference sr2 = new Reference("James", 1, 5, 6);
        Reference sr3 = new Reference("3 Nephi", 12, 48);
        Reference sr4 = new Reference("D&C", 88, 124);

        string ref1 = sr1.GetScriptureReference();
        string ref2 = sr2.GetScriptureReference();
        string ref3 = sr3.GetScriptureReference();
        string ref4 = sr4.GetScriptureReference();

    }
}