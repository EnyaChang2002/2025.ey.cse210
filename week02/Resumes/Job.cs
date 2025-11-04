public class Job
{
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    public void Display()
    {
        Console.WriteLine($"The job is {_jobTitle}");
        Console.WriteLine($"The company is {_company}");
    }

    public void DisplayDetail()
    {
        Console.WriteLine($"{_jobTitle} in the {_company} company. {_startYear} to {_endYear}");
    }
}