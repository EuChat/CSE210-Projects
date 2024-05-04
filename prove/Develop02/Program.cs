using System;
//Save other information in the journal entry.
class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        List<string> entries = new List<string>();


        Console.WriteLine("Welcome to the journal Program!");
        bool run = true;
        while (run)
        {
            Console.WriteLine("Please select one of the following choices:\n 1. Write  \n 2. Display \n 3. Save \n 4. Load \n 5. Quit ");
            Console.Write("\n What would you like to do?  ");
            
            string choice_possible = Console.ReadLine();
            int choice = int.Parse(choice_possible);

            if (choice == 1)
            {
                Entry newEntry = new Entry();
                newEntry.Display();
                journal.AddEntry(newEntry);
            }
            else if (choice == 2)
            {
                journal.DisplayAll();
            }
            else if (choice == 3)
            {
                journal.SaveToFile();
            }
            else if (choice == 4)
            {
                journal.LoadFromFile();
            }
            else if (choice == 5)
            {
                Console.WriteLine("Quit selected");
                run = false;
            }
            else 
            {
                Console.WriteLine("Invalid Input!");
            }
                
        }
    }
}