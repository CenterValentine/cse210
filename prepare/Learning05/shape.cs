
using System;

public class Shape
{

    protected string _color;

    public Shape()
    {

    }

    public void GetColor()
    {
        Console.WriteLine("Color is: " + _color);
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    public virtual void GetArea()
    {


    }
}
public class Square : Shape
{
Square (): base()
{
    _color = "Red";
}
  

}

public class Circle : Shape
{

}

public class Rectangle : Shape
{

}
