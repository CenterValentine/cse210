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
    }

}