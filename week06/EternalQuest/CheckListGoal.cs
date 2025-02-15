using System;

public class CheckListGoal: Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public CheckListGoal(string name, string description, string points,int target, int bonus) : base(name, description, points)
    {

    }


    public void RecordEvent()
    {

    }

    public bool IsComplete()
    {
        return false;
    }

    public string GetDetailstring()
    {
        return "";
    }

    public string GetStringRepresentation()
    {
        return "";
    }


}
