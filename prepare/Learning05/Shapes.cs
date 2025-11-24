using System.Drawing;

public abstract class Shapes()
{
    private string _color;

    public Shapes(string Color) : this()
    {
        _color = Color;
    }

    public string Get_Color()
    {
        return _color;
    }

    abstract public double Get_Area();
}