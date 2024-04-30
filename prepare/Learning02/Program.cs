using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();
            job1._jobTitle = "Data Engineer";
            job1._company = "Accenture";
            job1._startYear = 2021;
            job1._endYear = 2022;

        Job job2 = new Job();
            job2._jobTitle = "Data Engineer";
            job2._company = "IBM";
            job2._startYear = 2022;
            job2._endYear = 2025;

        Resume vileteResume= new Resume();
        vileteResume._name = "Luciano Vilete";

        vileteResume._jobs.Add(job1);
        vileteResume._jobs.Add(job2);

        vileteResume.Display();

    }
}