using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Journal DavidsJournal = new Journal();
        int menuStart()
        {
            List<string> menuOptions = new List<string> {
                "1. Write New Entry",
                "2. Display all entries",
                "3. Save",
                "4. Load",
                "5. ",
                "6 Quit"
                };

            Console.WriteLine("\nWelcome to JournalGPT!  Let's get started!");
            Console.WriteLine($"Select from one of the following menu options:");

            foreach (var option in menuOptions)
            {
                Console.WriteLine($"{option}");
            };
            Console.Write("> ");
            int menuSelection = int.Parse(Console.ReadLine());

            return menuSelection;
        }

        void menuReader(int menuSelection)
        {
            switch (menuSelection)
            {
                case 1:
                    // string input = Console.ReadLine();
                    Entry newEntry = new Entry();
                    PromptGenerator newPrompt = new PromptGenerator();
                    Console.WriteLine(newEntry._prompt = newPrompt.GetRandomPrompt());
                    newEntry._entry = Console.ReadLine();
                    DavidsJournal.AddEntry(newEntry);
                    break;
                case 2:
                    DavidsJournal.DisplayAll();
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
            }
        };


        int menuSelection = menuStart();
        while (menuSelection != 6)
        {
            menuReader(menuSelection);
            menuSelection = menuStart();
        }
    }


}