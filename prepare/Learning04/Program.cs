using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Bob's Uncle", "Multiplication");
        assignment.GetSummary();
        Math math = new Math("lakjsdfljasdf", "Kljsdflj");
        math.GetHomeworkList();
    }
}