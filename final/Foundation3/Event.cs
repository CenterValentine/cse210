using System;

public class Event
{
    private string _title;
    private string _description;
    private string _date;

    private string _time;
    private string _address;

    private List<string> _events;

    public Event(string title, string description, string date, string time, string address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string StandardDetails()
    {
        return "";
    }

    public string ShortDetails()
    {
        return "";
    }



}