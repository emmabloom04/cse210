using System;

class Program
{
    static void Main(string[] args)
    {

        int userChoice = 0;
        do {
            Console.Clear();
            Console.WriteLine("\nPlease pick your activity:\n\n1. Breathing activity\n2. Listing activity\n3. Reflection activity\n4. Quit");
            try {
                userChoice = int.Parse(Console.ReadLine());
            }
            catch {
                Console.WriteLine("Input must be a number between 1 and 4.");
                Thread.Sleep(1000);
            }
            if (userChoice == 1) {
                BreathingActivity breathingActivity = new BreathingActivity("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
                breathingActivity.RunActivity();
            }
            else if (userChoice == 2) {
                ListingActivity listingActivity = new ListingActivity("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                listingActivity.RunActivity();
            }
            else if (userChoice == 3) {
                ReflectionActivity reflectionActivity = new ReflectionActivity("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life. You will receive a prompt and questions to help you reflect on it. Take this time to reflect, no writing.");
                reflectionActivity.RunActivity();
            }
        } while (userChoice != 4);

    }
}