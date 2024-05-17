using System;
using System.Threading;

public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    public Activity(string name, string description, int duration)
{
    _name = name;
    _description = description;
    _duration = duration;    
}

public void DisplayStartingMessage()
{
    Console.WriteLine($"{_name} started: {_description}");
    Console.WriteLine("Please, prepare to begin...");
    ShowSpinner(3);
}
public void  DisplayEndingMessage()
{
    Console.WriteLine("Great job");
    Console.WriteLine($"You completed the {_name} for {_duration} seconds.");
    ShowSpinner(3);
}

public void ShowSpinner(int seconds)
{
    DateTime endTime = DateTime.Now.AddSeconds(seconds);
    while (DateTime.Now < endTime)
    {
        Console.Write("|");
        Thread.Sleep(250);
        Console.Write("\b/");
        Thread.Sleep(250);
        Console.Write("\b-");
        Thread.Sleep(250);
        Console.Write("\b\\");
        Thread.Sleep(250);
        Console.Write("\b");
    }
}

public void ShowCountDown(int seconds)
{
    for (int i = seconds; i > 0; i--)
    {
        Console.WriteLine(i);
        Thread.Sleep(1000);
    }
}
}

