using System;

public class Event
{
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;
    // private List<string> _events;

    public Event(string title, string description, string date, string time)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;

    }

    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string StandardDetails()
    {
        // return $"{_title}\n{_date}\n{_time}\n{_address}";
        return $"Please join us for the {_title} event on {_date} at {_time} located at {_address.FullAddress()}.";
    }

    public string ShortDetails()
    {
        // String eventType = typeof(Event).Name;
        // Subclass name 
        String subClassName = this.GetType().Name;
        // add space for outdoor gathering
        if (subClassName == "OutdoorGathering")
        {
            subClassName = "Outdoor Gathering";
        }

        return $"{subClassName}: {_title}\nDate: {_date}\nTime: {_time}\n";
    }





}