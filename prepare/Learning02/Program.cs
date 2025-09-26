using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        Job job2 = new Job();

        job1._company = "Univsion Computers";
        job1._jobTitle = "Field Engineer";
        job1._startYear = 2022;
        job1._endYear = 2032;

        job2._company = "Harlows";
        job2._jobTitle = "School Bus Driver";
        job2._startYear = 2018;
        job2._endYear = 2022;

        Resume myResume = new Resume();
        myResume._name = "Charity Becker";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.DisplayResumeDetails();
    }
}