using System;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    public void FillPromptList()
    {
        // Fill _prompts with new prompts.
        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("What was the strongest emotion I felt today?");
        _prompts.Add("If I had one thing I could do over today, what would it be?");
        _prompts.Add("What did I do today to improve myself today?");
        _prompts.Add("What do I want to do differently tomorrow?");
        _prompts.Add("In what activity did I spend most of my day doing?");
        _prompts.Add("I'm I happy with how this day turned out? Why?");
        _prompts.Add("Why did I do that certain 'thing'?");
    }

    public string ChoosePrompt()
    {
        // Ask the user to write an original prompt, or choose one randomly.
        Console.WriteLine();
        Console.WriteLine("Would you like to write your own prompt? [y/n]");
        Console.Write("> ");
        string input = Console.ReadLine();

        if (input == "y")
        {
            // Ask the user to write an orignal prompt. Then, return the prompt.
            Console.WriteLine();
            Console.WriteLine("Write your own prompt:");
            Console.Write("> ");
            string prompt = Console.ReadLine();

            return prompt;
        }
        else
        {
            // Create a Random object.
            Random randomGenerator = new Random();

            // Randomly select a prompt and return it.
            int randomNum = randomGenerator.Next(0, _prompts.Count);
            return _prompts[randomNum];            
        }
    }
}