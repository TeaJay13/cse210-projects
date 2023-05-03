using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2008;
        job1._endYear = 2018;
        job1.Display();

        Job job2 = new Job();
        job2._jobTitle = "Electrical Engineer";
        job2._company = "Apple";
        job2._startYear = 2005;
        job2._endYear = 2013;
        job2.Display();

        Resume myResume = new Resume();
        myResume._name = "John Smith";
        
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();

    }
}


public class Job
{
    public string _jobTitle;

    public string _company;
    public int _startYear;
    public int _endYear;
    public void Display()
    {
        Console.WriteLine($"Job: {_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}

public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        // Notice the use of the custom data type "Job" in this loop
        foreach (Job job in _jobs)
        {
            // This calls the Display method on each job
            job.Display();
        }
    }
}
