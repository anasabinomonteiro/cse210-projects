using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Doglas Monteiro", "Multiplication");
        Console.WriteLine(assignment.GetSummary());    
    
        MathAssignment mathAssignment = new MathAssignment("Doglas Monteiro", "Multiplication", "8.4", "6-14");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());    

    
        WritingAssignment writingAssignment = new WritingAssignment("Benjamin Monteiro", "African History", "Rescue of Ancestry");
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }    
}