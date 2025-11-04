using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        Resume resume1 = new Resume();
        resume1._name = "Alma";
        job1._jobTitle = "Flower Shop owner";
        job1._company = "A";
        job1._startYear = 2019;
        job1._endYear = 2020;
        //job1.DisplayDetail();

        Job job2 = new Job();

        //Console.WriteLine($"{resume1._jobs[0]._jobTitle}");
        
        job2._jobTitle = "Novel Writer";
        job2._company = "B";
        job2._startYear = 2020;
        job2._endYear = 2024;
        //job2.DisplayDetail();

        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.Display();

        /*
        Console.WriteLine("Hello World! This is the Resumes Project.");
        */
    }
}