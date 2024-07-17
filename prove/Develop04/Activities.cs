
using System;

public class Activity
{
    protected string _name;
    protected string _description;

    protected int _duration;

    protected int _numberOfActivities;

    protected Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }


    protected void CountAndReportActivities()
    {
        _numberOfActivities++;
        Console.WriteLine($"You have completed {_numberOfActivities} activities.");
    }


    protected void DisplayStartingMessage()
    {
        Console.WriteLine($"This is the {_name} Activity. \n {_description}.\n");
        Console.Write($"How many seconds would you like to do this activity? ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("\n");
    }



    protected void ShowPauseSpinner(int mode = 0)
    {
        switch (mode)
        {
            case 1:
                Thread.Sleep(1250);
                for (int j = 0; j < 3; j++)
                {
                    Thread.Sleep(1250);
                    Console.Write(".");
                }
                break;
            default:
                // int timer = 0;
                List<string> spinner = new List<string> { "|", "/", "-", "\\" };
                // reverse spinner
                List<string> spinnerReverse = new List<string> { "\\", "-", "/", "|" };
                int i = 0;
                int numberOfSeconds = 5;
                while (i < numberOfSeconds)
                {

                    // Each cylcle of the spinner takes ~ 1 second
                    foreach (string spin in spinner)
                    {
                        Console.Write($"\r{spin}");
                        Thread.Sleep(75);
                        Console.Write($"\b{spin}\b");
                    }
                    foreach (string spin in spinner)
                    {
                        Console.Write($"\r{spin}");
                        Thread.Sleep(75);
                        Console.Write($"\b{spin}\b");
                    }

                    foreach (string spin in spinnerReverse)
                    {
                        Console.Write($"\r{spin}");
                        Thread.Sleep(75);
                        Console.Write($"\b{spin}\b");
                    }

                    foreach (string spin in spinnerReverse)
                    {
                        Console.Write($"\r{spin}");
                        Thread.Sleep(75);
                        Console.Write($"\b{spin}\b");
                    }
                    i++;

                    Console.Write("\b \b");
                }

                break;

        }
    }

    protected void ShowCountDown(int seconds = 3)
    {
        Console.Write($"Get ready to start in...  ");
        Thread.Sleep(1000);
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"\b\b\b\b\b... {i}");
            Thread.Sleep(1000);
        }
        Console.WriteLine("\n");
        // Console.Clear();


    }

    protected void DisplayEndingMessage()
    {
        Console.WriteLine($"Nice work! You have completed {_name}! You completd the activity in {_duration} seconds.");
    }


}
