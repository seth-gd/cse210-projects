using System;

class Program
{
    static void Main(string[] args)
    {
        // Instatiate new objects
        Scripture scripture = new Scripture();
        Reference reference = new Reference("John", 3, 16);
        Word word = new Word();

        // Pass the reference to "scripture"
        scripture.SetReference(reference.GetFullReference());

        // Declare an input variable and start the while loop.
        string input = "";
        bool stopLoop = false;
        while (input != "quit" && stopLoop == false)
        {
            // Display the scripture
            scripture.DisplayFullScripture();

            // Ask the user for input (press Enter or type "quit")
            Console.WriteLine();
            Console.WriteLine("Press Enter to continue. Type 'quit' to exit.");
            Console.Write("> ");
            input = Console.ReadLine();

            // Replace a word with underscores
            word.SetWordList(scripture.GetScriptureList());
            word.HideWord();
            scripture.SetScriptureList(word.GetWordList());
            
            // Check if the list has only underscore strings
            stopLoop = word.CheckList();
        }
    }
}