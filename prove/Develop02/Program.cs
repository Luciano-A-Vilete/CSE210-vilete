using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");

        Journal myJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        bool running = true;
        while (running)
        {
            Console.WriteLine("1. Write Entry");
            Console.WriteLine("2. Display All Entries");
            Console.WriteLine("3. Save to File");
            Console.WriteLine("4. Load from File");
            Console.WriteLine("5. Quit");

            Console.Write("Select an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter today's date (MM/DD/YYYY): ");
                    string date = Console.ReadLine();
                    string prompt = promptGenerator.GeneratePrompt();
                    Console.WriteLine($"Prompt: {prompt}");
                    Console.Write("Write your entry: ");
                    string entryText = Console.ReadLine();
                    Entry newEntry = new Entry(date, prompt, entryText);
                    myJournal.AddEntry(newEntry);
                    break;
                case "2":
                    Console.WriteLine("All Entries:");
                    myJournal.DisplayAll();
                    break;
                case "3":
                    Console.Write("Enter file name to save: ");
                    string saveFileName = Console.ReadLine();
                    myJournal.SaveToFile(saveFileName);
                    Console.WriteLine("Journal saved to file.");
                    break;
                case "4":
                    Console.Write("Enter file name to load: ");
                    string loadFileName = Console.ReadLine();
                    myJournal.LoadFromFile(loadFileName);
                    Console.WriteLine("Journal loaded from file.");
                    break;
                case "5":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}