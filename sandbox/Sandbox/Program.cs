using System;
using System.Runtime.ExceptionServices;
// same as import statements

class Program
{

    static void Main(string[] args) // you need to have a static main func for the program to work
    {
        Console.WriteLine("Hello Sandbox World!");
        Circle myCircle = new Circle(10);
        Console.WriteLine($"{myCircle.GetArea()}");

    }
}