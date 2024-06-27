using System;

public class Job()
{
    public string _jobTitle;
    public string _jobDescription;

    public DateOnly _jobCreationDate;

    public string _jobSalary;

    public string _jobCompanyName;

    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_jobTitle} for {_jobCompanyName}: {_jobDescription} This job pays {_jobSalary} and was created on {_jobCreationDate}.");
    }
}