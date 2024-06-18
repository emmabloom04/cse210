using System.Runtime.InteropServices.Marshalling;

class Resume {

    private string _member;
    List<Job> jobs = new List<Job>();

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
        jobs.Add(job);
    }

}