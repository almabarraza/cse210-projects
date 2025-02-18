using System;
using System.Reflection.Metadata.Ecma335;

public abstract class Goal
{
    protected string _shortName;
    private string _description;
    private string _points;


    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
        
    }

    public abstract void RecordEvent();
  

    public abstract bool IsComplete();
   

    public virtual string GetDetailString()
    {
        if (IsComplete() == false)
        {
            return $"[ ] {_shortName} ({_description}) {_points}";
        }
        else
        {
            return $"[X] {_shortName} ({_description}) {_points}";
        }
    }

    public abstract string GetStringRepresentation();

    public virtual string GetName()
    {
        return _shortName;
    }
   
    public virtual string GetPoints()
    {
        return _points;
    }




}