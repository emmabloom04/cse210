using System;
using System.Runtime.InteropServices.Marshalling;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int count = -1;
        int userNumber = 5;
        List<int> numbers = new List<int>();

        do 
        {
            Console.Write("Enter number: ");
            userNumber = int.Parse(Console.ReadLine());
            numbers.Add(userNumber);
            count += 1;
        } while (userNumber != 0);

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        
        int average = sum / count;
        int max = numbers.Max();
        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Average: {average}");
        Console.WriteLine($"Max: {max}");
    }
}