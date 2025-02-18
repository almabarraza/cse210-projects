using System;

public class EternalGoal: Goal
{
    private string _name;
    private string _description;
    private string _points;
    
    public EternalGoal(string name, string description, string points) : base(name, description, points)
    {
        _name = name;
        _description = description;
        _points = points;
    }


    public override void  RecordEvent()
    {

    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"Eternal Goal:{_name},{_description},{_points}";
    }


}