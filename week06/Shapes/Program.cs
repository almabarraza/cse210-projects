using System;

class Program
{
    static void Main(string[] args)
    {

        List<Shape> shapes = new List<Shape>();
         double area;
         string color;


       // Square square = new Square("Red",5);
       // area = square.GetArea();
       // Console.WriteLine($"Area: {area}");
//
       // color = square.GetColor();
       // Console.WriteLine($"Color: {color}");
//
//
       // Rectangle rectangle = new Rectangle("blue", 20, 10);
       // area = rectangle.GetArea();
       // Console.WriteLine($"Area: {area}");
       // color = rectangle.GetColor();
       // Console.WriteLine($"Color: {color}");
//
       // Circle circle = new Circle("Yellow", 5);
       // area = circle.GetArea();
       // Console.WriteLine($"Area: {area:F2}");
       // color = circle.GetColor();
       // Console.WriteLine($"Color: {color}");

        
        Square square = new Square("Red",5);
        shapes.Add(square);
        Rectangle rectangle = new Rectangle("blue", 20, 10);
        shapes.Add(rectangle);
        Circle circle = new Circle("Yellow", 5);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            area = shape.GetArea();
            color = shape.GetColor();
            Console.WriteLine($"Area: {area:F2}");  
            Console.WriteLine($"Color: {color}");
        }



    }
}