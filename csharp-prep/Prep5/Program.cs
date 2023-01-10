using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int userNum = PromptUserNumber();
        int squareNum = SquareUserNumber(userNum);
        DisplayResult(userName, squareNum);
    }

    static void DisplayWelcome() 
    {
        Console.WriteLine("Welcome to the Program!");
    }
    
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string userInput = Console.ReadLine();
        int userNum = int.Parse(userInput);
        return userNum;
    }

    static int SquareUserNumber(int num)
    {
        int squareNum = num * num;
        return squareNum;
    }

    static void DisplayResult(string userName, int squareNum)
    {
        Console.WriteLine($"{userName}, the square of your number is {squareNum}");
    }
}