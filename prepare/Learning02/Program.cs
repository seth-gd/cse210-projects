using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "McDonalds";
        job1._jobTitle = "Manager";
        job1._startYear = 2020;
        job1._endYear = 2021;

        Job job2 = new Job();
        job2._company = "Waffle House";
        job2._jobTitle = "Dish Washer";
        job2._startYear = 2022;
        job2._endYear = 2023;

        Resume resume = new Resume();
        resume._name = "Eduardo Pansa";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);
        resume.DisplayResume();
    }
}