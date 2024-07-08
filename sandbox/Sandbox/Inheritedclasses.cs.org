class Program
{

    static void Main(string[] args) // you need to have a static main func for the program to work
    {
        Console.WriteLine("Hello Sandbox World!");

        Person person1 = new Person("Bob", "Billy", 34, 210);
        Console.WriteLine(person1.PersonInformation());

        Fireman fireman = new Fireman("EMT and Parametic", "Betty", "Billy", 35, 130);
        Console.WriteLine(fireman.PersonInformation());
        // method from person class can be used in the fireman class because of inheritance
        Console.WriteLine(fireman.FiremanInformation());

        Policeman policeman = new Policeman("Taser and club", "Sally", "Smith", 54, 120);
        Console.WriteLine(policeman.PersonInformation());
        Console.WriteLine(policeman.PolicemanInformation());

    }
}