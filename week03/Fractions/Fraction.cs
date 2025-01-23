using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
         _top = 1;
         _bottom = 1;
        
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;

    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;

    }

  //  public void SetTop(int top)
   // {
     //   _top = top;
   // }


    //public void GetTop()
    //{
      //  Console.WriteLine(_top);
   // }

    //public void SetBottom(int bottom)
    //{
      //  _bottom = bottom;

    //}

    //public void GetBottom()
    //{
      //  Console.WriteLine(_bottom);
   // }

    public string GetFractionString()
    {
        
        string stringFraction = $"{_top} / {_bottom}";
        return(stringFraction);

    }

    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
        
    }







}

