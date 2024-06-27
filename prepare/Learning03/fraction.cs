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
    public Fraction(int numbertop)
    {
        _top = numbertop;
        _bottom = 1;
    }

    public Fraction(int numbertop, int numberbottom)
    {
        _top = numbertop;
        _bottom = numberbottom;
    }

    public void init()
    {
        _top = 1;
        _bottom = 1;
    }

    public void SetTop(int top)
    {
        top = _top;
    }

    public int GetTop()
    {
        return _top;
    }

    public void SetBottom(int bottom)
    {
        bottom = _bottom;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public string GetFractionString()
    {

    }
}