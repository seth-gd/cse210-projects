using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Define the variables and create a list
        Console.WriteLine("Enter a list of numbers; type 0 when finished.");
        string numString;
        int num = 1;
        List<int> numbers = new List<int>();

        // While loop to add items into numbers
        while (num != 0) {
            Console.Write("Enter number: ");
            numString = Console.ReadLine();
            num = int.Parse(numString);

            numbers.Add(num);
        }

        // Calculate the total sum of numbers
        int sum = 0;
        foreach (int i in numbers) {
            sum = sum + i;
        }
        Console.WriteLine($"The sum is: {sum}");

        // Calculate the average of numbers
        float average = ((float)sum) / (numbers.Count - 1);
        Console.WriteLine($"The average is: {average}");

        // Determine the highest number in numbers
        int max = 0; 
        foreach (int i in numbers) {
            if (i > max) 
            {
                max = i;
            }
        }
        Console.WriteLine($"The largest number is: {max}");
    }
}