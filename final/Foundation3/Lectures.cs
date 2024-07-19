using System;

public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity) : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public Lecture(string title, string description, string date, string time, string speaker, int capacity) : base(title, description, date, time)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public string FullDetails()
    {
        // includeds type of event
        return $"Please join us for the lecture titled {_title} on {_date} at {_time} located at {_address.FullAddress()}. Our guest speaker will be {_speaker}. \nSpace is limited to {_capacity} attendees.";
    }
}
