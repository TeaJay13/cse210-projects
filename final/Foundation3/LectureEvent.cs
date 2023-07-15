using System;


public class LectureEvent : Event
{
    private string _speaker;
    private int _capacity;
    
     public string Speaker
    {
        get { return _speaker; }
        set { _speaker = value; }
    }

    public int Capacity
    {
        get { return _capacity; }
        set { _capacity = value; }
    }

    public LectureEvent(string title, string description, DateTime date, TimeSpan time, Address address, string speaker, int capacity) 
        : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

   

    public override string GetFullDetails()
    {
        return base.GetFullDetails() + $"\nSpeaker: {_speaker}\nCapacity: {_capacity}";
    }
}
