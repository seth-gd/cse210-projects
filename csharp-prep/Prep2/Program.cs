using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user for input; define and parse variables
        Console.Write("What is your grade? ");
        string grade = Console.ReadLine();
        int gradeNum = int.Parse(grade);

        string gradeLetter;

        // Determine the letter grade
        if (gradeNum >= 90)
        {
            gradeLetter = "A";
        }
        else if (gradeNum >= 80)
        {
            gradeLetter = "B";
        }
        else if (gradeNum >= 70)
        {
            gradeLetter = "C";
        }
        else if (gradeNum >= 60)
        {
            gradeLetter = "D";
        }
        else
        {
            gradeLetter = "F";
        }

        Console.WriteLine($"Your grade is: {gradeLetter}");

        // Tell the user if the grade is a passing grade
        if (gradeNum >= 70) {
            Console.WriteLine("Congratulations! You passed the semester.");
        }
        else {
            Console.WriteLine("You failed the semester. Try again next time.");
        }
    }
}