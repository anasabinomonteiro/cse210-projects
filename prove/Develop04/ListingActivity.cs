using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts;
    private int _count;
    public ListingActivity(List<string> prompts) : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 20)
    {
        _prompts = prompts;
        _count = 0;
    }
    public void Run()
    {
        DisplayStartingMessage();
        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);
        ShowCountDown(5);
        List<string> items = GetListFromUser();
        _count = items.Count;
        Console.WriteLine($"You listed {_count} items.");
        DisplayEndingMessage();        
    }

    public List<string> GetListFromUser()
    {
        List<string> items = new List<string>();
        Console.WriteLine("start listing itms: ");
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now <endTime)
        {
            string item = Console.ReadLine();
            if (!string.IsNullOrEmpty(item))
            {
                items.Add(item);
            }
        }
            return items;
        }      
    public string GetRandomPrompt() /* verify void*/
        {
            Random random = new Random();
            return _prompts[random.Next(_prompts.Count)];
        }
}