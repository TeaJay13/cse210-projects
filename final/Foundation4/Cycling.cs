using System;

public class Cycling : Activity
{
    private double _speed;

    public double speed
    {
        get{return _speed;}
        set{_speed = value;}
    }

    public Cycling(DateTime date, int lengthMinutes, double speed) : base(date, lengthMinutes)
    {
        _speed = speed;
    }

    public override double GetSpeed()
    {
        return speed;
    }

    public override double GetPace()
    {
        return 60 / speed;
    }

    public override string GetSummary()
    {
        string paceFormatted = GetPace().ToString("F2");
        return $"{date:dd MMM yyyy} Cycling ({lengthMinutes} min) - Speed: {speed} kph, Pace: {paceFormatted} min per km";
    }
}
