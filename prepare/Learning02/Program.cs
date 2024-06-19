using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Junior Developer";
        job1._jobCompanyName = "Azure Standard";
        job1._jobDescription = "We are looking for someone who knows how to code.";
        job1._jobSalary = "$55,000";
        job1._jobCreationDate = new DateOnly(2021, 10, 1);

        Job job2 = new Job();
        job2._jobTitle = "Senior Developer";
        job2._jobCompanyName = "Standard Plumbing";
        job2._jobDescription = "We are looking for someone who knows more how to code than a junior developer.";
        job2._jobSalary = "$75,000";
        job2._jobCreationDate = new DateOnly(2021, 10, 1);

        // job1.DisplayJobDetails();

        Resume resume1 = new Resume();

        resume1._resumeName = "David Valentine";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.Display();


    }
}