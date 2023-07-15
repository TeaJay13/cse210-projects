using System;

public class ReceptionEvent : Event
{
    private string _rsvpEmail;
    
    public string RsvpEmail
    {
        get { return _rsvpEmail; }
        set { _rsvpEmail = value; }
    }
    public ReceptionEvent(string title, string description, DateTime date, TimeSpan time, Address address, string rsvpEmail) 
        : base(title, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }

    

    public override string GetFullDetails()
    {
        return base.GetFullDetails() + $"\nRSVP Email: {_rsvpEmail}";
    }
}
