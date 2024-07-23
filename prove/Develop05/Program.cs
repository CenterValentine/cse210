using System;

class Program
{
    static void Main(string[] args)
    {

        // This program contains many features that are not present in the original original assignment:
        // A random points can be assigned if no input is given
        // The users previous points are loaded for goals that are not eternal.
        // Loading wipes previous score and goals replacing them with the saved file.
        // Unique messaging for when goals are completed.
        
        GoalManager goalManager = new GoalManager();
        Console.Clear();
        goalManager.start();
    }
}