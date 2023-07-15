using System;

public class Swimming : Activity
{
    private int _laps;

    public int laps
    {
        get{return _laps;}
        set{_laps = value;}
    }

    public Swimming(DateTime date, int lengthMinutes, int laps) : base(date, lengthMinutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return laps * 50 / 1000 * 0.62;
    }

    public override double GetSpeed()
    {
        return GetDistance() / lengthMinutes * 60;
    }

    public override double GetPace()
    {
        return lengthMinutes / GetDistance();
    }

    public override string GetSummary()
    {
        string paceFormatted = GetPace().ToString("F2");
        return $"{date:dd MMM yyyy} Swimming ({lengthMinutes} min) - Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {paceFormatted} min per mile";
    }
}
