
using System;

class Assignment
{
    private string _studentName;
    private string _topic;

    public Assignment()
{
    _studentName = "annonymous";
    _topic = "no topic";
}
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    
    public void GetSummary()
    {
        Console.WriteLine( $"Student: {_studentName}, Topic: {_topic}");
    }
    
}