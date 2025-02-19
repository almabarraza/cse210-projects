using System;

public class Cycling: Activity
{
    private double _speed;
    private string _date;
    private int _lenghtInMinutes;
    private string _nameActivity;




    public Cycling(string date, int lenghtInMinutes, string nameActivity, double speed) : base(date, lenghtInMinutes, nameActivity)
    {
        _speed = speed;
        _lenghtInMinutes = lenghtInMinutes;
        _date = date;
        _nameActivity = nameActivity;
        
    }


    public override double GetPace()
    {
        double pace = 60/_speed;
        return pace;

    }

    public override double GetDistance()
    {

        double distance = (GetPace() * 50) / 1000;
        return distance;
    }

    public override string GetSummary()
    {
         return $"{base.GetSummary()} Distance {GetDistance()} Km, Speed {_speed} kph, Pace: {GetPace():2F} min per km";
    }

    public override double GetSpeed()
    {
        return _speed;
    }




}