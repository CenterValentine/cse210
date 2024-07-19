using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Lecture lecture = new Lecture("History of Baskets", "A deep dive into the history of basket weaving", "10/19/2024", "4:00 PM",new Address("123 Basketweave Lane", "Weavetown","ND", "12585"), "Dr. Basket", 50);

        Reception reception = new Reception("McCan Hertz N Hao", "Meet and greet with Attorney McCan Hertz N Hao", "10/19/2024", "6:00 PM", new Address("456 Bum St", "Cream", "WI", "54321"),"McCanHertz@law.com");
        
        OutdoorGathering outdoorGathering = new OutdoorGathering("Jumping Activity", "A fun day of jumping", "10/19/2024", "12:00 PM", new Address("789 Hop St", "Jump", "CA", "67890"), "Sunny");

        List<Event> events = new List<Event> { lecture, reception, outdoorGathering };

        // Polymorphism would be best to use here, but is omitted for the assignment
        int i = 0;
        foreach (Event eVents in events)
        {
            Console.WriteLine(eVents.StandardDetails());
            Console.WriteLine();
            switch (i)
            {
                case 0:
                    Console.WriteLine(lecture.FullDetails());
                    break;
                case 1:
                    Console.WriteLine(reception.FullDetails());
                    break;
                case 2:
                    Console.WriteLine(outdoorGathering.FullDetails());
                    break;
            }
            Console.WriteLine();
            Console.WriteLine(eVents.ShortDetails());
            Console.WriteLine("--------------------------------------------------");
            i++;
        }

    }
}