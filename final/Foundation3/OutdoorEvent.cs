using System;


public class OutdoorEvent : Event
{
    private string _weather;
    
    public string Weather
    {
        get { return _weather; }
        set { _weather = value; }
    }
    public OutdoorEvent(string title, string description, DateTime date, TimeSpan time, Address address, string weather) 
        : base(title, description, date, time, address)
    {
        _weather = weather;
    }

    

    public override string GetFullDetails()
    {
        return base.GetFullDetails() + $"\nWeather: {_weather}";
    }
}
