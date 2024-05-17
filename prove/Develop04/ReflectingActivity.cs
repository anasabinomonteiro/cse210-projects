using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity(List<string> prompts, List<string> questions) : base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience.",20)
    {
        _prompts = prompts;
        _questions = questions;
    }

    public void Run()
    {
        DisplayStartingMessage();
        string prompt = GetRandomPrompt();
        DisplayPrompt(prompt);
        ShowSpinner(5);
        foreach (var question in _questions)
        {
        DisplayQuestion(question);
        ShowSpinner(5);     
        }
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        return _prompts[random.Next(_prompts.Count)];
    }

    public string GetRandomQuestion()
    {
        Random random = new Random();
        return _questions[random.Next(_questions.Count)];
    }

    public void DisplayPrompt(string prompt)
    {
        Console.WriteLine(prompt);
    }

    public void DisplayQuestion(string question)
    {
        Console.WriteLine(question);
    }
}    