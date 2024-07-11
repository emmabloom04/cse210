class Menu {

    public void DisplayMenu() {
        Console.WriteLine("\nWelcome to the Eternal Quest Program!");
        Console.WriteLine("What would you like to do?");
        Console.WriteLine("\n1. Write new goal");
        Console.WriteLine("2. Record an event");
        Console.WriteLine("3. Load goals");
        Console.WriteLine("4. Write goals to a file");
        Console.WriteLine("5. Display goals");
        Console.WriteLine("6. Quit");
    }

    public void InterpretChoice(int userChoice) {
        if (userChoice == 1) {
            Console.WriteLine("\nHere you will write a new goal :)");
        }
        else if (userChoice == 2) {
            Console.WriteLine("\nHere you will record a completion of a goal!");
        }
        else if (userChoice == 3) {
            Console.WriteLine("\nThe program will do its magic and load in information from the file of your choice!");
        }
        else if (userChoice == 4) {
            Console.WriteLine("\nThe program will do some magic and write what's already in this program to a file of your choice!");
        }
        else if (userChoice == 5) {
            Console.WriteLine("\nHere the program will display your list of goals :)");
        }
    }
}