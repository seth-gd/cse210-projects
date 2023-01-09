using System;

class Program
{
    static void Main(string[] args)
    {
        // Get the magic number
        Random randomGenerator = new Random();
        int magicNum = randomGenerator.Next(1, 101);

        // Declare the variables used in the do while loop
        string userInput;
        int userNum;

        // Run the game loop
        do
        {
            // Ask the user to take a guess
            Console.Write("What is your guess? ");
            userInput = Console.ReadLine();
            userNum = int.Parse(userInput);

            // Determine if the user guessed right
            if (userNum > magicNum) 
            {
                Console.WriteLine("lower");
            }
            else if (userNum < magicNum)
            {
                Console.WriteLine("higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        } while (userNum != magicNum);
    }
}