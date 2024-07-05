using System;
using System.Dynamic;

class Math : Assignment
{

    private string _textbookSection;
    private string _problems;

    public Math(string textbookSection, string problems)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public void GetHomeworkList()
    {
        Console.WriteLine($"{_textbookSection} : {_problems}");
    }

    

}