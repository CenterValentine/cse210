using System;

public class Receptions : Event
{
    private string _email;
    public Receptions(string title, string description, string date, string time, string address, string email) : base(title, description, date, time, address)
    {
        _email = email;
    }

    public string FullDetails()
    {
        return $"Please join us for the reception titled {_title} on {_date} at {_time}.  We are located at {_address}.  Contact us at {_email} for more information.";
    }


}