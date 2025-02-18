using System;

public class CheckListGoal: Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    private string _name;
    private string _description;
    private string _points;

    public CheckListGoal(string name, string description, string points,int target, int bonus, int amountComplited) : base(name, description, points)
    {
        _name = name;
        _description = description;
        _points = points;
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountComplited;

    }


    public override void RecordEvent()
    {
        _amountCompleted = _amountCompleted + 1;
        
    }

    public override bool IsComplete()
    {
        if (_amountCompleted != _target)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public override string GetDetailString()
    {
        string details = base.GetDetailString();
       return $"{details} ---Currently complited {_amountCompleted}/{_target}";
              
    }

    public override string GetStringRepresentation()
    {
        return  $"CheckList Goal:{_name},{_description},{_points},{_bonus},{_target},{_amountCompleted}";
    }

     public override string GetPoints()
    {
        if (IsComplete() == true)
        { 
            return (int.Parse(_points) + _bonus).ToString();
        }
        else
        {
            return _points;
        }
    } 


}
