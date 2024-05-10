using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture(new Reference("John", 3, 16),"For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");

        // Display complete scripture
        DisplayScriputure(scripture);

        //Loop until all the words are hidden
        while (!scripture.IsCompletelyHidden())
        {
            //Ask for user to press Enter ou write "quit"
            Console.WriteLine("Press Enter to continue or 'quit' to finish the program");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            //Hidden more words and continue the loop
            scripture.HideRandomWords(1);
            Console.Clear();
            DisplayScriputure(scripture);
        }

        Console.WriteLine("You chose to leave, see you later.");
    }
    static void DisplayScriputure(Scripture scripture)
    {
        Console.WriteLine(scripture.GetDisplayText());
    }
}