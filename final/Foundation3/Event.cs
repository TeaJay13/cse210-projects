using System;


public class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public string title
    {
        get { return _title; }
        set { _title = value; }
    }

    public string description
    {
        get { return _description; }
        set { _description = value; }
    }

    public string date
    {
        get { return _date; }
        set { _date = value; }
    }

    public string time
    {
        get { return _time; }
        set { _time = value; }
    }

    public Address address
    {
        get { return _address; }
        set { _address = value; }
    }

    public Event(string title, string description, string date, string time, Address address)
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
