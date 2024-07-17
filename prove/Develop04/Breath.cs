using System;

class Breath : Activity
{
    public Breath() : base("Breathing Activity", "This activity will help you relax by walking your through your breathing. Clear your mind and focus on your breathing.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();
        ShowCountDown();

        int numberOfBreaths = _duration / 10;

        if (numberOfBreaths < 10){
            Console.WriteLine("We'll give you at least 10 seconds to complete a breath.");
        }

        if (_duration % 10 != 0)
        {
            numberOfBreaths++;
        }
        Console.WriteLine($"You will take {numberOfBreaths} deep 10 second breaths...");
        for (int i = 0; i < numberOfBreaths; i++)
        {
            Console.Write("\nBreathe in");
            ShowPauseSpinner(1);
            Console.Write("\nBreathe out");
            ShowPauseSpinner(1);
        }
        Console.WriteLine("\n");
        DisplayEndingMessage();

        System.Threading.Thread.Sleep(2000);
        CountAndReportActivities();
    }

}