class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");

        Employee employee = new Employee("Bob", 40, 23.77);

        ConstructionWorker constructionWorker = new ConstructionWorker("Betty", 40, 35.88);

        Doctor doctor = new Doctor("Belinda", 240000.99);

        List<Employee> employees = new List<Employee>();
        employees.Add(employee);
        employees.Add(constructionWorker);
        employees.Add(doctor);

        foreach (Employee e in employees) {
            Console.WriteLine($"{e.GetName()} is due: ${e.GetPay()}");
        }

    }
}