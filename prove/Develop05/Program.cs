using System;

class Program
{
    static void Main(string[] args)
    {
        int userChoice = 0;
        Menu menu = new Menu();

        while (userChoice != 6) {
            do {
                menu.DisplayMenu();
                userChoice = int.Parse(Console.ReadLine());
            } while (userChoice > 6 || userChoice < 1);
            menu.InterpretChoice(userChoice);
        }
    }
}