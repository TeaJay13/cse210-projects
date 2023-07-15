using System;


public class Event
{
    private string _title;
    private string _description;
    private DateTime _date;
    private TimeSpan _time;
    private Address _address;

    public string Title
    {
        get { return _title; }
        set { _title = value; }
    }

    public string Description
    {
        get { return _description; }
        set { _description = value; }
    }

    public DateTime Date
    {
        get { return _date; }
        set { _date = value; }
    }

    public TimeSpan Time
    {
        get { return _time; }
        set { _time = value; }
    }

    public Address Address
    {
        get { return _address; }
        set { _address = value; }
    }

    public Event(string title, string description, DateTime date, TimeSpan time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

   
    public virtual string GetStandardDetails()
    {
        return $"Title: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {_address.FullAddress}";
    }

    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }

    public string GetShortDescription()
    {
        return $"Type: {GetType().Name}\nTitle: {_title}\nDate: {_date}";
    }
}
