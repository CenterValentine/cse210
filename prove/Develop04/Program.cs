using System;
using System.ComponentModel.Design;
using System.Diagnostics;

// This program returns the number of activities participated
// and the breathing activity tells the user who wants an activity less than 10 seconds that they will have one full breath cylce if duration is < 10 seconds.
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        int input = 0;

        while (input != 4)
        {
            // menu system choose activity
            Console.WriteLine("\n Choose an activity: \n 1) Start Breathing Actiivty \n 2) Start Reflection activiity \n 3) Start List Writing acitivity \n 4) Quit\n");
            input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                    Breath breath = new Breath();
                    breath.Run();
                    break;
                case 2:
                    Reflect reflect = new Reflect();
                    reflect.Run();
                    break;
                case 3:
                    Listing listing = new Listing();
                    listing.Run();
                    break;
                default:

                    break;
            }
        };





    }
}