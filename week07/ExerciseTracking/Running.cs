using System;

public class Running: Activity
{
    private double _distance;
    private string _date;
    private int _lenghtInMinutes;
    private string _nameActivity;
  


    public Running(string date, int lenghtInMinutes, string nameActivity, double distance) : base(date, lenghtInMinutes, nameActivity)
    {
        _distance = distance;
        _lenghtInMinutes = lenghtInMinutes;
        _date = date;
        _nameActivity = nameActivity;

    }

    public override double GetSpeed()
    {
        double _speed = (_distance / _lenghtInMinutes) * 60;
        return _speed;
       
    }

  

    public override double GetPace()
    {
      return _lenghtInMinutes / _distance;
    }

    public override double GetDistance()
    {
       return _distance;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} Distance {_distance} Km, Speed {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }


}