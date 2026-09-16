using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Customer Support Specialist";
        job1._company = "Mekundo Creations";
        job1._startYear = 2025;
        job1._endYear = 2026;

        Job job2 = new Job();
        job2._jobTitle = "Software Developer Student";
        job2._company = "BYU-Idaho";
        job2._startYear = 2026;
        job2._endYear = 2026;

        Resume myResume = new Resume();
        myResume._name = "Napio Mercy Elizabeth";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}