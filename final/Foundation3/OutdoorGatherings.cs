using System;

public class OutdoorGatherings : Event
{
    private string _weatherForecast;

    public OutdoorGatherings(string title, string description, string date, string time, string address, string weatherForecast) : base(title, description, date, time, address)
    {
        _weatherForecast = weatherForecast;
    }
    public string FullDetails()
    {
        // weather
        return "";
    }
}