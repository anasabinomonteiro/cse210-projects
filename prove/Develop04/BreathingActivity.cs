using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by breathing in and out slowly", 20)
    {
    }

    public void Run()
    {
        DisplayStartingMessage();
        for (int i = 0; i < _duration / 10; i++)
        {
            Console.WriteLine("Breathe in ...");
            ShowCountDown(5);
            Console.WriteLine("Breathe out...");
            ShowCountDown(5);
        }
        DisplayEndingMessage();
    }
}
