using System.Net.NetworkInformation;

public class Circle : Shapes
{
    private double _radius;

    public Circle(double R, string Color) : base (Color)
    {
        _radius = R;
        
    }

    public override double Get_Area()
    {
        return Math.PI*(_radius*_radius);
    }
}