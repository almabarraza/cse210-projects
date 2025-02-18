using System;


public class SimpleGoal: Goal
{
    private bool _isComplete;
    private string _name;
    private string _description;
    private string _points;
    

    public SimpleGoal(string name, string description, string points, bool isComplete) : base(name, description, points)
    {
        _name = name;
        _description =description;
        _points = points;
        _isComplete = isComplete;

    }


    public override void RecordEvent()
    {
        _isComplete = true;


    }

    public override bool IsComplete()
    {
        if(_isComplete == false)
        {
            return false;
        }
        else
        {
            return true;
        }
        
        

    }

    public override string GetStringRepresentation()
    {
        return $"Simple Goal:{_name},{_description},{_points},{_isComplete}";
    }





}