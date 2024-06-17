using System;

class Program
{
    static void Main(string[] args)
    {

        List<int> listOfNumbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int userNumber = -1;

        while (userNumber != 0)
        {
            Console.WriteLine("Enter Number: ");
            userNumber = int.Parse(Console.ReadLine());
            if (userNumber == 0)
            {
                break;
            };
            listOfNumbers.Add(userNumber);
        }

        // Sum and Average
        int listOfNumbersSum = 0;

        foreach (int number in listOfNumbers)
        {
            listOfNumbersSum = listOfNumbersSum + number;
        }

        float listOfNumbersAvg = (float)listOfNumbersSum / listOfNumbers.Count;


        // Average number
        int maxNumber = listOfNumbers[0];

        foreach (int number in listOfNumbers)
        {
            if (number > maxNumber)
            {
                maxNumber = number;
            }
        }
        Console.WriteLine($"The sum is: {listOfNumbersSum}");
        Console.WriteLine($"The average is: {listOfNumbersAvg}");
        Console.WriteLine($"The max number is: {maxNumber}");
        // sort the list
        // List<int> SortedList = listOfNumbers.OrderBy(number => number).ToList();
        // Console.WriteLine($"The sorted list is: {SortedList}");
    }
}