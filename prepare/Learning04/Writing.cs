using System;
using System.Dynamic;

class Writing : Assignment
{

private string _title;

public Writing(string title){
    _title = title;
}

protected void GetWritingInformation()
{
 Console.WriteLine($"{_title}");
}

}