using System;

public class Reception : Event
{
    private string _email;
    public Reception(string title, string description, string date, string time, Address address, string email) : base(title, description, date, time, address)
    {
        _email = email;
    }

    public Reception(string title, string description, string date, string time, string email) : base(title, description, date, time)
    {
        _email = email;
    }

    public string FullDetails()
    {
        return $"Please join us our reception for {_title} on {_date} at {_time}.  We are located at {_address.FullAddress()}.  Contact us at {_email} for more information.";
    }


}