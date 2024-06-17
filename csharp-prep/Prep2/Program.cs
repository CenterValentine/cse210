using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter a number score to receive a grade: ");
        int grade = int.Parse(Console.ReadLine());
        string letter = "";
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }

        else if (grade >= 70)
        {
            letter = "C";
        }

        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        if (grade > 70)
        {
            Console.WriteLine($"Your grade: {letter}");
            Console.WriteLine("Congradulations! You've passed!!");
        }
        else
        {
            Console.WriteLine("You got what you deserved...  Just kidding. You are learning! Don't give up and try again! ");
        }
    }
}