using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning02 World!");
        Job job1 = new Job();
        job1._jobTitle = "Billing Analyst";
        job1._company = "Compass Group";
        job1._startYear = 2003;
        job1._endYear = 2015;

        Job job2 = new Job();
        job2._jobTitle = "System Analyst";
        job2._company = "SFA Informatica";
        job2._startYear = 2018;
        job2._endYear = 2024;

        // //Display Job Company         
        // job1.Display();
        // job2.Display();

        Resume myResume = new Resume();
        myResume._name = "Ana Monteiro";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();

    }
}