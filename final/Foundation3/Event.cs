using System;

public class Event
{
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected string _address;
    // private List<string> _events;

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
        return $"Please join us for the event titled {_title} on {_date} at {_time} located at {_address}.";
    }

    public string ShortDetails()
    {
        String eventType = typeof(Event).Name;
        // list eventtype
        return $"{eventType}: {_title} Date: {_date} Time: {_time}";
    }





}