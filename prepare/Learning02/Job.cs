using System;

public class Job
{
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;
         

    // // Display Company    
    // public  void Display(string property)
    // {
    //      switch(property)
    //     {
    //         case "_company":
    //             Console.WriteLine($"{_company}");
    //             break;
        
    //     }
    // }

    // Display all data
    public  void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
    
}
     
    


