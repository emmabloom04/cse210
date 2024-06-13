using System;
using System.Runtime.ExceptionServices;
// same as import statements

class Program
{

    static double CalculateCircleArea(double radius)
    // all functions start with an uppercase letter, whereas variables start with a lowercase.
    // both have every word capitalized (except for the first word for vars), no underscores (camel case)
    {
        double area = 0;
        area = Math.PI * radius * radius;
        return area;
    }

    static void Main(string[] args) // you need to have a static main func for the program to work
    {
        Console.WriteLine("Hello Sandbox World!");

        // int userAge = -10;

        // like the while loops we're used to in python
        // while (userAge < 0 || userAge > 120) // take note: NO SEMI-COLON at the end of this
        // {
        //     Console.Write("Please input your age (0-120): ");
        //     userAge = int.Parse(Console.ReadLine());
        // }

        // userAge = 9;

        // a do while loop means the loop will execute at least once.
    //     do
    //     {
    //         Console.Write("Please input your age (0-120): ");
    //         userAge = int.Parse(Console.ReadLine());
    //     } while (userAge < 0 || userAge > 120);

    int x = 0;
    x++; // this increments the var by 1.
    x--; // this decreases the var by 1

    // for loop

    // for (var = starting point; range; how much you want to increment by)
    // for not incrementing by 1, it's i += 12
    // for (int i = 0; i < 100; i++)
    // {
    //     Console.WriteLine(i);
    // }

    // compare to python: 
    // for i in range(100)

    // lists
    List<int> myNumbers = new List<int>(); // declaring a list, in this list there can only be ints
    List<string> myNames = new List<string>(); // and this list can only have strings
    // these are empty lists

    List<int> myNumbers2 = new List<int> {1, 2, 3, 4, 5, 6, 7, 8}; // declaring a list with items already in it

    myNames.Add("Bob"); // Add = append in python
    myNames.Add("Billy");
    myNames.Add("Betty");

    // this type of loop goes through items in a list
    foreach (string name in myNames)
    {
        Console.WriteLine(name);
    }

    // functions
    // Syntax:
    // returnType FunctionName(datatype p1, datatype p2, ...)
    // {
        // Code Block
    // }

    // void means there is nothing returned

    // using the function we defined above main
    double area = CalculateCircleArea(10);
    Console.WriteLine(area);
    }
}