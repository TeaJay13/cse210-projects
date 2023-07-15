using System;

public class Running : Activity
{
    private double _distance;

    public double distance
    {
        get{return _distance;}
        set{_distance = value;}
    }

    public Running(DateTime date, int lengthMinutes, double distance) : base(date, lengthMinutes)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return distance;
    }

    public override double GetSpeed()
    {
        return distance / lengthMinutes * 60;
    }

    public override double GetPace()
    {
        return lengthMinutes / distance;
    }

    public override string GetSummary()
    {
        string paceFormatted = GetPace().ToString("F2");
        return $"{date:dd MMM yyyy} Running ({lengthMinutes} min) - Distance: {distance} miles, Speed: {GetSpeed()} mph, Pace: {paceFormatted} min per mile";
    }
}
