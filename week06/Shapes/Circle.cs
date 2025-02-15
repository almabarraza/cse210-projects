using System;

public class Circle: Shape
{
    private double _radius;
    private string _color;


    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
        _color = color;
        
    }


    public override double GetArea()
    {
        return 3.1416 * (_radius * _radius);
    }





}