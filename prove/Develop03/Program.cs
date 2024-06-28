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

        // start program
        string scripture_text = "50 But, behold, the servant said unto the Lord of the vineyard: Spare it a little longer. 51 And the Lord said: Yea, I will spare it a little longer, for it grieveth me that I should lose the trees of my vineyard.";
        Scripture scripture = new Scripture(new Reference("Jacob", "5", "50", "51"), scripture_text);
        string input = BlahStart(scripture);

        if (input == "y")
        {
            Console.WriteLine("Enter a scripture reference:");
            string referenceText = Console.ReadLine();

            Console.WriteLine("Enter the text of the scripture:");
            string referenceContent = Console.ReadLine();
            scripture = new Scripture(new Reference(referenceText), referenceContent);
        }


        while (input.ToLower() != "quit")
        {
            // switch (input.ToLower())
            // {
            //     case "quit":
            //         break;
            //     case "h":
            //         scripture.Hint();
            //         break;
            //     default:
            //         Console.Clear();
            //         scripture.DisplayAll();
            //         scripture.HideRandomWord();
            //         break;
            // }

            input = BlahMenu();
            if (input.ToLower() == "h")
            {

            }

            else if (input.ToLower() == "quit")
            { break; }

            else
            {
                Console.Clear();
                scripture.DisplayAll();
            }


        }
    }

}


