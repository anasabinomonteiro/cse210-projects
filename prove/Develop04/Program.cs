using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop04 World!");
        List<string> listingPrompts = new List<string>
        {
            "Who are the people you appreciate?",
            "What are your personal strengths?",
            "When did you feel the Holy Spirit this month?",
            "Who are some of your personal heroes?",
            "Who are the people you have helped this week?",
        };

         List<string> reflectionPrompts = new List<string>
         {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
         };

         List<string> reflectingQuestions = new List<string>
         {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What is your favorite thing about this experience?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
         };

         while (true)
        {
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Listing Activity");
            Console.WriteLine("3. Reflecting Activity");
            Console.WriteLine("4. Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.Run();
                    break;
                case "2":
                    ListingActivity listingActivity = new ListingActivity(listingPrompts);
                    listingActivity.Run();
                    break;
                case "3":
                    ReflectingActivity reflectingActivity = new ReflectingActivity(reflectionPrompts, reflectingQuestions);
                    reflectingActivity.Run();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please select again.");
                    break;
            }
        }
    }
}