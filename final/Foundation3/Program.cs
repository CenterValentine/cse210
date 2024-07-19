using System;

class Program
{
    static void Main(string[] args)
    {
        //  write a program that creates at least one event of each type and sets all of their values.
        //  Then, for event event, call each of the methods to generate the marketing messages and 
        // output their results to the screen.

        Lectures lecture = new Lectures("Lecture on the History of Baskets", "A deep dive into the history of basket weaving", "10/19/2024", "4:00 PM", "123 Weave St", "Dr. Basket", 50);
        Receptions reception = new Receptions("Reception for McCan Hertz N Hao", "Meet and greet with Attorney McCan Hertz N Hao", "10/19/2024", "6:00 PM", "456 Bum St", "MrHertz@law.com");
        OutdoorGatherings outdoorGathering = new OutdoorGatherings("Outdoor Jumping Activity", "A fun day of jumping", "10/19/2024", "12:00 PM", "789 Hop St", "Cloudy");

        List<Event> events = new List<Event> { lecture, reception, outdoorGathering };
        lecture.FullDetails();
        reception.FullDetails();
        outdoorGathering.FullDetails();

        foreach (Event eVents in events)
        {
            Console.WriteLine(eVents.StandardDetails());
            Console.WriteLine(eVents.ShortDetails());
        }

    }
}