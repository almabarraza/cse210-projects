using System;
using System.Dynamic;

public class Shape
{

    protected string _color;


    public Shape(string color)
    {
       SetColor(color);

    }

    public string GetColor()
    {

        return _color;
    }


    public void SetColor(string color)
    {
        _color = color;
        
    }

    public virtual double GetArea()
    {   
        return .0;
    }








}
