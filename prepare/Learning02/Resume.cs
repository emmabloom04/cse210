using System.Runtime.InteropServices.Marshalling;

class Resume {

    private string _member;
    List<string> jobs = new List<string>();

    public Resume() {

    }
    
    public string GetMemberName()
    {
        Console.Write("Please enter your name: ");
        return _member = Console.ReadLine();
    }

    public void AddJobs()
    {
        Job job = new Job();
        string company = job.GetCompany();
        string jobTitle = job.GetJobTitle();
        string startYear = job.GetStartYear();
        string endYear = job.GetEndYear();
        string jobInformation = job.JobInformation();
        jobs.Add(jobInformation);
    }

    public void Display()
    {
        Console.WriteLine($"Name: {_member}");
        Console.WriteLine("Jobs:");
        foreach (string job in jobs) {
            Console.WriteLine(job);
        }
    }

}