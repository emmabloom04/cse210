using System.Runtime.InteropServices.Marshalling;

class Job 
{
    private string _company;
    private string _jobTitle;
    private string _startYear;
    private string _endYear;
    private string _jobInformation;

    public Job() { 

    }

    public string GetCompany()
    {
        Console.Write("Enter your company: ");
        return _company = Console.ReadLine();
    }

    public string GetJobTitle()
    {
        Console.Write("Enter your job title: ");
        return _jobTitle = Console.ReadLine();
    }

    public string GetStartYear()
    {
        Console.Write("Enter your start year: ");
        return _startYear = Console.ReadLine();
    }

    public string GetEndYear()
    {
        Console.Write("Enter your end year: ");
        return _endYear = Console.ReadLine();
    }

    public string JobInformation()
    {
        return _jobInformation = $"{_jobTitle} ({_company}) {_startYear}-{_endYear}";
    }
}