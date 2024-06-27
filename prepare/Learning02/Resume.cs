using System;

public class Resume()
{
    public string _resumeName = null;
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_resumeName}");
        Console.WriteLine("Jobs: ");
        foreach (Job job in _jobs)
        {
            job.DisplayJobDetails();
        }
    }

}
