using System;

class Program
{
    static void Main(string[] args)
    {
        
        Fraction fraction1 = new Fraction();
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());
        
        Fraction fraction2 = new Fraction(5);
        //fraction2.SetTop(5);
        //fraction2.GetTop();
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue());
        
        Fraction fraction3 = new Fraction(3,4);
        //fraction3.SetTop(2);
        //fraction3.GetTop();
        //fraction3.SetBottom(4);
        //fraction3.GetBottom();
        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());
        
        Fraction fraction4 = new Fraction(1,3);
        Console.WriteLine(fraction4.GetFractionString());
        Console.WriteLine(fraction4.GetDecimalValue());


    }
}