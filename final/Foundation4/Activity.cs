using System;

public class Activity
{
    public DateTime date;
    private int _lengthMinutes;

    public int lengthMinutes
    {
        get{return _lengthMinutes;}
        set{_lengthMinutes = value;}
    }

 

    public Activity(DateTime date, int lengthMinutes)
    {
        this.date = date;
        _lengthMinutes = lengthMinutes;
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public virtual string GetSummary()
    {
        return "";
    }
}
