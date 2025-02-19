using System;

public class Swimming: Activity
{
    private int _numberOfLaps;
    private string _date;
    private int _lenghtInMinutes;
    private string _nameActivity;




    public Swimming(string date, int lenghtInMinutes, string nameActivity, int numberOfLaps) : base(date, lenghtInMinutes, nameActivity)
    {
        _numberOfLaps = numberOfLaps;
        _lenghtInMinutes = lenghtInMinutes;
        _date = date;
        _nameActivity = nameActivity;

    }

    public override double GetSpeed()
    {
        double speed = 60 / _numberOfLaps;
        return speed;
    }

    public override double GetDistance()
    {
        double distance = (_numberOfLaps * 50) / 1000;
        return distance;
    }


    public override string GetSummary()
    {
         return $"{base.GetSummary()} Distance {GetDistance()} Km, Speed {GetSpeed()} kph, Pace: {_numberOfLaps} min per km";
    }

    public override double GetPace()
    {
        return _numberOfLaps;
    }

}