using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);
        Console.WriteLine(number);
        
        Console.WriteLine("Welcome to the number game! You will be guessing a random number from 1 to 100.");

        int userGuess;

        do 
        {
            Console.Write("Guess: ");
            string guess = Console.ReadLine();
            userGuess = int.Parse(guess);
            if (userGuess > 100 || userGuess < 0)
            {
                Console.WriteLine("That number is out of the range.");
            }
            else if (number > userGuess)
            {
                Console.WriteLine($"The number is higher than {userGuess}.");
            }
            else if (number < userGuess)
            {
                Console.WriteLine($"The number is lower than {userGuess}.");
            }
        } while (userGuess != number);

        Console.WriteLine("Great job! You guessed it!");
    }
}