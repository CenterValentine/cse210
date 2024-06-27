using System;

public class Entry()
{
    // public static int _entryid = 0;
    
    public string _entry;
    public string _date;
    public string _prompt;
    //promptGenerator    

    public void displayEntry()
    {
        Console.WriteLine($"{_date}: {_prompt} {_entry}");
    }
}