using System;
using System.Collections.Generic;

class OutDoorGathering : Event
{
    private string weatherForecast;
    public OutDoorGathering(string title, string description, string date, string time, Address address, string weatherForecast)
    : base(title, description, date, time, address)
    {
        this.weatherForecast = weatherForecast;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetStandardDetails()}\nEvent Type: Outdoor Gathering\nWeather Forcast: {weatherForecast}";
    }
}