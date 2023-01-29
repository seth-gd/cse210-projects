using System;

class Program
{
    static void Main(string[] args)
    {
        // ---------- EXCEEDING REQUIREMENTS ----------
        // The Journal Program doesn't automatically choose a random prompt. First, the program asks the user if
        // they would like to write their own prompt. The user needs to enter "y", and this prompt will be saved
        // along with the date and entry. If the user enters "n" or anything else, the program chooses a prompt 
        // randomly.

        // Define all necessary variables.
        PromptGenerator promptGenerator = new PromptGenerator();
        Entry entry = new Entry();
        Journal journal = new Journal();
        string input;
        string prompt;

        promptGenerator.FillPromptList();

        // Start the loop.
        do
        {
            // Display the interface.
            Console.WriteLine("Please select one of the following choices by typing a number:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do?");

            // Grab input from the user.
            Console.Write("> ");
            input = Console.ReadLine();

            if (input == "1")
            {   
                // Randomly generate a prompt and display it.
                prompt = promptGenerator.ChoosePrompt();

                // Create a new entry.
                Console.WriteLine();
                string newEntry = entry.CreateEntry(prompt);
                Console.WriteLine();

                // Add the entry to journal.
                journal._allEntries.Add(newEntry);
            }
            else if (input == "2")
            {
                // Iterate through the list of entries an display each entry
                Console.WriteLine();
                foreach (string line in journal._allEntries)
                {
                    Console.WriteLine(line);
                }
            }
            else if (input == "3")
            {
                // Load a file and add each entry into a list.
                Console.WriteLine();
                journal.LoadFile();
                Console.WriteLine();
            }
            else if (input == "4")
            {
                // Save the list of entries in a file.
                Console.WriteLine();
                journal.SaveFile();
                Console.WriteLine();
            }
            else
            {
                // If the user doesn't write any option, just ignore, write a blank line, and continue the loop.
                Console.WriteLine();
            }
        } while (input != "5");
    }
}