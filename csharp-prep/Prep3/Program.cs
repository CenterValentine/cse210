using System;

class Program
{
    static void Main(string[] args)
    {
        string play_again = "yes";
        while (play_again == "yes") {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);
        // Console.WriteLine($"Magic Number: {magicNumber}");

        // Console.WriteLine("What is the magic number? ");
        // int magicNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("I'm thinking of a number!");
        


        Console.WriteLine("What do you think the magic number is? ");
        int guessNumber = int.Parse(Console.ReadLine());

        do
        {
        
        

        if (guessNumber > magicNumber)
        {
            Console.WriteLine("Lower");
            Console.WriteLine("Guess again!");
            guessNumber = int.Parse(Console.ReadLine());
        }
        else if (guessNumber < magicNumber)
        {
            Console.WriteLine("Higher");
            Console.WriteLine("Guess again!");
            guessNumber = int.Parse(Console.ReadLine());
        }
        } while (guessNumber != magicNumber );

        Console.WriteLine($"You guessed it!  The magic number was {magicNumber}!");
        Console.WriteLine("Would you like to play again?");
        play_again = Console.ReadLine();

        }
        Console.WriteLine("Thanks for playing!");


    }
}