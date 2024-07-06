using System;

class Reflect : Activity
{

    private List<string> _promptList = new List<string> {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."};

    private List<string> _reflectQuestions = new List<string> {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"};


    public Reflect() : base("Reflecting", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {

    }



    private void GetRandomPrompt()
    {
        Random random_number = new Random();
        string prompt = _promptList[random_number.Next(_promptList.Count)].ToString();
        Console.Write($"{prompt} \n");
    }

    private void GetRandomQuestion()
    {
        Random random_number = new Random();
        string question = _reflectQuestions[random_number.Next(_reflectQuestions.Count)].ToString();
        Console.WriteLine($"{question}\n");

    }

    public void Run()
    {
        DisplayStartingMessage();

        GetRandomPrompt();
        Console.Write("When you are ready to start reflecting, press enter to continue.");
        Console.Read();
        Console.WriteLine("\nNow ponder on any of following questions in light of that experience: ");
        ShowCountDown();

        DateTime futureTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < futureTime)
        {
            GetRandomQuestion();
            ShowPauseSpinner();
        }
        Console.WriteLine("\n Time is up! \n");

        DisplayEndingMessage();

    }

}