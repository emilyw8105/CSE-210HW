public class Rectangle : Shapes
{
    private double _side1;
    private double _side2;

    public Rectangle(double Side1, double Side2, string Color) : base (Color)
    {
        _side1 = Side1;
        _side2 = Side2;
       
    }

    public override double Get_Area()
    {
        return _side1*_side2;
    }
}