using System;

class Listing : Activity
{
    private List<string> _promptList = new List<string> {
    "What are things that you are grateful for?",
    "Who are people that you appreciate?",
    "What are personal strengths of yours?",
    "What are things that you have done well this week?",
    "Who are people that you have helped this week?",
    "What are things that you have learned this week?",
    "What are things that you have accomplished this week?",
    "What are things that you are looking forward to?",
    "When have you felt the Holy Ghost this month?",
    "What are some of your favorite memories?",
    "Who are some of your personal heroes?",
};

    protected List<string> _responseList = new List<string>();

    public Listing() : base("List Writing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    private void GetRandomPrompt()
    {
        Random random_number = new Random();
        int promptindex = random_number.Next(_promptList.Count);
        Console.WriteLine(_promptList[promptindex]);

    }
    public void Run()
    {
        DisplayStartingMessage();
        
        Console.WriteLine("\nStart pondering about the prompt below: ");
        GetRandomPrompt();
        ShowCountDown();

        Console.WriteLine("\nStart writing your list until the timer stops you. \n");

        DateTime futureTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < futureTime)
        {
            _responseList.Add(Console.ReadLine());
        }



        Console.WriteLine("\n Time is up! \n");
        Console.WriteLine($"Here is your list: {string.Join(", ", _responseList)}");
        System.Threading.Thread.Sleep(2000);
        CountAndReportActivities();




        // DateTime futureTime = DateTime.Now.AddSeconds(_duration);
        // while (DateTime.Now < futureTime)
        // {
        //     ShowPauseSpinner();
        // }
        // Console.WriteLine("\n Time is up! \n");

        // DisplayEndingMessage();

    }





}