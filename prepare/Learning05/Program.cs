using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shapes> shape = new List<Shapes>();
        shape.Add(new Square(2, "Red"));
        shape.Add(new Rectangle(2, 4, "Yellow"));
        shape.Add(new Circle(5, "Green"));

        foreach (Shapes S in shape){
            string Color = S.Get_Color();
            double Area = S.Get_Area();

            Console.WriteLine($"The shape is {Color} and has an area of: {Area}");
        }
    }
}