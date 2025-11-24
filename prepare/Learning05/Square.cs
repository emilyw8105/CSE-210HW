using System.Formats.Asn1;

public class Square : Shapes
{
    private double _side;

    public Square(double Side, string Color) : base (Color)
    {
        _side = Side;
        
    }

    public override double Get_Area()
    {
        return _side*_side;
    }
}