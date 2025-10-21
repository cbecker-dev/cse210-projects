using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();

        while (true)
        {
            Console.WriteLine("Journal Menu");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();
            Console.WriteLine();

            if (choice == "1")
            {
                string prompt = promptGen.GetRandomPrompt();
                Console.WriteLine($"Prompt: {prompt}");
                Console.Write("Your response: ");
                string response = Console.ReadLine() ?? "";
                Entry entry = new Entry(DateTime.Now.ToString("yyyy-MM-dd"), prompt, response);
                journal.AddEntry(entry);
                Console.WriteLine("Entry added.\n");
            }
            else if (choice == "2")
            {
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.Write("Filename to save to: ");
                string name = Console.ReadLine();
                try
                {
                    journal.SaveToFile(name);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Could not save: {ex.Message}\n");
                }

            }
            else if (choice == "4")
            {
                Console.Write("Filename to load from: ");
                string name = Console.ReadLine();
                try
                {
                    journal.LoadFromFile(name);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Could not load: {ex.Message}\n");
                }
            }
            else if (choice == "5")
            {
                break;
            }
            else
            {
                Console.WriteLine("Please choose 1 to 5.\n");
            }
        }
    }
}