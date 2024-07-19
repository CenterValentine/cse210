using System;

public class Lectures : Event
{
    private string _speaker;
    private int _capacity;

    public Lectures(string title, string description, string date, string time, string address, string speaker, int capacity) : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public string FullDetails()
    {
        // includeds type of event
        return $"Please join us for the lecture titled {_title} on {_date} at {_time} located at {_address}. Our guest speaker will be {_speaker}. \nSpace is limited to {_capacity} attendees.";
    }
}
