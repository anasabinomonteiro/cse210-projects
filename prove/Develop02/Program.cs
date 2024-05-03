using System;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        
        Console.WriteLine("Welcome, it is time to write in your Jounal Program!");
        String choice;
        do
        {
            Console.WriteLine("Please select one option of the following choices below:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What do you like to do? ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                // Give a PromptGenerator question,user replies,record the date, prompt and reply user in the list 
                PromptGenerator promptGenerator = new PromptGenerator();
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(prompt);
                Console.WriteLine();
                string entryText = Console.ReadLine();
                string currentdate = DateTime.Now.ToString("MM/dd/yyyy");

                Entry newEntry = new Entry
                {
                    _date = currentdate,
                    _prompText = prompt,
                    _entryText = entryText
                };

                journal.AddEntry(newEntry);
            }

            else if (choice == "2")
            {
                // Display date , prompt and entry
                journal.DisplayAll();
            }

            else if (choice == "3")
            {
                // Did the load of the an existent file and  fills in the related fields in the List 
                Console.WriteLine("Enter the filename to load: ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);                  
            }  

            else if (choice == "4")
            {
                // Save the data in a file (.txt, .csv, .json, etc...)
                Console.WriteLine("Enter the filename to save: ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }

            else if (choice == "5")
            {
                //Quit and closes the program
                Console.WriteLine("Closing journal..Hope to eee you soon!");
            }

            else
            {
                Console.WriteLine("Invalid choice! Please, select a valid option: ");
            }
            Console.WriteLine();       
        }
        while (choice != "5");
    }
}