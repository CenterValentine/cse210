using System;

public class OutdoorGathering : Event
{
    private string _weatherForecast;

    public OutdoorGathering(string title, string description, string date, string time, Address address, string weatherForecast) : base(title, description, date, time, address)
    {
        _weatherForecast = weatherForecast;
    }

    public OutdoorGathering(string title, string description, string date, string time, string weatherForecast) : base(title, description, date, time)
    {
        _weatherForecast = weatherForecast;
    }
    public string FullDetails()
    {
        return $"Title: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {_address.FullAddress()}\nWeather Forecast: {_weatherForecast}";
    }
}