using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019 ;
        job1._endYear = 2023 ;

        Job job2 = new Job();
        job2._jobTitle = "Frontend Developer";
        job2._company = "Amazon" ;
        job2._startYear = 2017 ;
        job2._endYear = 2018 ;

        Job job3 = new Job();
        job3._jobTitle = "Software Quality Engineer";
        job3._company = "Facebook";
        job3._startYear = 2014;
        job3._endYear = 2017;

        Resume MyOwnResume = new Resume();
        MyOwnResume._name= "Diego Bellido";
        MyOwnResume._jobs.Add(job1);
        MyOwnResume._jobs.Add(job2);
        MyOwnResume._jobs.Add(job3);

        MyOwnResume.Display();
        

    }
}