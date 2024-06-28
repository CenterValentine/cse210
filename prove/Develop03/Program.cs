using System;


class Program
{


    static void Main(string[] args)
    {
        Console.Clear();

        // Introduction
        string BlahStart(Scripture scripture)
        {
            Console.WriteLine("\nWelcome to the Scripture Memory Program!\n");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine($"Would you like to enter a scripture? (y/n) ");
            Console.Write("(default scripture: ");
            scripture.DisplayReference();
            Console.Write(")\n");
            string input = Console.ReadLine();
            return input;
        }

        string BlahMenu()
        {
            Console.WriteLine("\n\nPress Enter to continue hiding words or type quit to exit.");
            Console.WriteLine("Type H/h for a hint!");
            string input = Console.ReadLine();
            return input;
        }

        string scripture_text = "50 But, behold, the servant said unto the Lord of the vineyard: Spare it a little longer. 51 And the Lord said: Yea, I will spare it a little longer, for it grieveth me that I should lose the trees of my vineyard.";
        Scripture scripture = new Scripture(new Reference("Jacob", "5", "50", "51"), scripture_text);


        string input = BlahStart(scripture);
        while (true)
        {
            switch (input.ToLower())
            {
                case "quit":
                    scripture.DetectEndProgram(1, input.ToLower());
                    break;
                case "y":
                    Console.WriteLine("Enter a scripture reference:");
                    string referenceText = Console.ReadLine();
                    Console.WriteLine("Enter the text of the scripture:");
                    string referenceContent = Console.ReadLine();
                    scripture = new Scripture(new Reference(referenceText), referenceContent);
                    Console.Clear();
                    scripture.DisplayAll();
                    input = BlahMenu();
                    break;
                case "h":
                    scripture.Hint();
                    input = BlahMenu();
                    break;
                case "":
                    Console.Clear();
                    scripture.HideRandomWord();
                    scripture.DisplayAll();
                
                    input = BlahMenu();
                    break;
                case "n":
                    Console.Clear();
                    scripture.DisplayAll();
                    input = BlahMenu();
                    break;
                default:
                    Console.WriteLine("Invalid input. Please try again.");
                    input = BlahMenu();
                    break;
            }


        }
    }

}


