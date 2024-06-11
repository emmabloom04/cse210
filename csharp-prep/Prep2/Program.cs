using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("Please input your grade as a number: ");
        string grade = Console.ReadLine();
        double gradeNumber = Convert.ToDouble(grade);
        string letter;

        if (gradeNumber >= 90)
        {
            letter = "A";
        }
        else if (gradeNumber >= 80)
        {
            letter = "B";
        }
        else if (gradeNumber >= 70)
        {
            letter = "C";
        }
        else if (gradeNumber >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        if (gradeNumber >= 70)
        {
            Console.WriteLine("Good work! You passed the class.");
        }
        else
        {
            Console.WriteLine("You didn't pass the class. Try harder next time.");
        }
        Console.WriteLine($"You have a {letter} in the class.");
    }
}