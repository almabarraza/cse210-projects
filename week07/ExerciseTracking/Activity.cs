using System;

public abstract class Activity
{
    private string _date;
    private int _lenghtInMinutes;
    private string _nameActivity;


    public Activity(string date, int lenghtInMinutes, string nameActivity)
    {
        _date = date;
        _lenghtInMinutes = lenghtInMinutes;
        _nameActivity = nameActivity;

    }

    public abstract double GetDistance();

    public abstract double GetSpeed();
    
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{_date} {_nameActivity} ({_lenghtInMinutes} min)-";
    }



}



