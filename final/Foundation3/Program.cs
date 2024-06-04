using System;

class Program
{
    static void Main(string[] args)
    {
        // Creating address
        var address1 = new Address("954 Main St", "Springfield", "IL", "USA");
        var address2 = new Address("376 Elm St", "Toronto", "ON", "Canada");

       // Creating events
       var lecture = new Lecture("C# Programming Lecture", "An in-depth lecture on C# programming.", "2024-06-03", "10:00 AM", address1, "Doglas Monteiro", 100);
       var reception = new Reception("Totvs Business Networking Event", "An opportunity to network with Totvs professionals.", "2024-07-12", "3:00 PM", address2, "rsvptotvs@business.com");
       var outdoorGathering = new OutDoorGathering("June Festival", "A fun outdoor festival with music and food.", "2024-07-10", "2:00 PM", address1, "Sunny");

       // Add events to mail list
       var events = new List<Event> {lecture, reception, outdoorGathering};

       // Display Information
       foreach (var eventItem in events)
       {
        Console.WriteLine("Standard details:");
        Console.WriteLine(eventItem.GetStandardDetails());
        Console.WriteLine("Full details:");
        Console.WriteLine(eventItem.GetFullDetails());
        Console.WriteLine("Short description:");
        Console.WriteLine(eventItem.GetShortDescription());
        Console.WriteLine();        
       }
    }
}