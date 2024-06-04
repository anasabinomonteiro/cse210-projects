using System;

class Program
{
    static void Main(string[] args)
    {
       var activities = new List<Activity>
       {
        new Running(new DateTime(2024, 4, 5), 30, 3.0), //3 miles in 30 min
        new Cycling(new DateTime(2024,7, 5), 45, 15.0), // 15 mph for 45 min
        new Swimming(new DateTime(2024, 11, 5), 20, 40) // 40 laps in 20 min
       };

       foreach (var activity in activities)
       {
        Console.WriteLine(activity.GetSummary());
       }
    }
}