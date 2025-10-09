using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Job Job1 = new Job();
        Job1._JobTitle = "Software Engineer";
        Job1._Company = "Microsoft";
        Job1._StartYear = 2019;
        Job1._EndYear = 2022;

        Job Job2 = new Job();
        Job2._JobTitle = "Manager";
        Job2._Company = "Apple";
        Job2._StartYear = 2022;
        Job2._EndYear = 2023;

        

        Resume myResume = new Resume();
        myResume._Name = "Allison Rose";

        myResume._Jobs.Add(Job1);
        myResume._Jobs.Add(Job2);

        myResume.Display();
    }

    
    
}
   
