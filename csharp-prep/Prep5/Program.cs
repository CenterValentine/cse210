using System;
using System.Globalization;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        //  - Displays the message, "Welcome to the Program!"
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }
        //  - Asks for and returns the user's name (as a string)
        static string PromptUserName()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            return name;
        }

        // Asks for and returns the user's favorite number (as an integer)

        static int PromptUserNumber()
        {
            Console.WriteLine("What is your favorite number?");
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        // Accepts an integer as a parameter and returns that number squared(as an integer)

        static string SquareNumber(int toBeSquared)
        {
            int squaredNumber = toBeSquared * toBeSquared;
            string squaredNumberString = squaredNumber.ToString();
            return squaredNumberString;

        }

        // Accepts the user's name and the squared number and displays them.
        static void DisplayResults(string displayOne, string displayTwo)
        {
            Console.WriteLine($"Hello {displayOne}, your favorite number squared is {displayTwo}");
        }

        static void Main()
        {
            DisplayWelcome();
            string userName = PromptUserName();
            int userNumber = PromptUserNumber();
            string squaredNumber = SquareNumber(userNumber);
            DisplayResults(userName, squaredNumber);
        }

        Main();

    }
}