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
                "5. Store in Airtable (do not use)",
                "6. Retrieve from Airtable (do not use)",
                "7. Quit"
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
                    Entry newEntry = new Entry();
                    PromptGenerator newPrompt = new PromptGenerator();
                    // write or writeline?
                    Console.WriteLine(newEntry._prompt = newPrompt.GetRandomPrompt());
                    newEntry._entry = Console.ReadLine();
                    newEntry._date = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
                    DavidsJournal.AddEntry(newEntry);
                    break;
                case 2:
                    DavidsJournal.DisplayAll();
                    break;
                case 3:
                    Console.Write("What is the file name? ");
                    string fileName = Console.ReadLine();
                    List<Entry> Entries = DavidsJournal._Entries;
                    DavidsJournal.saveEntries(fileName, Entries);
                    break;
                case 4:
                    Console.Write("What is the file name? ");
                    string fileName1 = Console.ReadLine();
                    DavidsJournal.loadEntries(fileName1);
                    break;
                // case 5:
                //     await DavidsJournal.FetchJournalEntries;
                //     break;
                case 6:

                    break;
                case 7:
                    Console.WriteLine("Goodbye!");
                    Environment.Exit(0);
                    break;
            }
        };


        int menuSelection = menuStart();
        while (menuSelection != 7)
        {
            menuReader(menuSelection);
            menuSelection = menuStart();
        }
    }


}