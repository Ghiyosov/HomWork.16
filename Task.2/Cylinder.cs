using System.Drawing;

namespace Task;

public class Cylinder : Shape
{
    public double Radius { get; set; }
    public double Height { get; set; }
    public Cylinder(string color, double radius, double height):base(color)
    {
        Radius = radius;
        Height = height;
    }
    public Cylinder()
    {
        
    }
    //S=2πR (h+R)
    public override void CalculateArea()
    {
        System.Console.WriteLine((2*(Math.PI)*Radius)*(Height + Radius));
    }
    //V = π × r² × h
    public override void CalculateVolume()
    {
        System.Console.WriteLine((Math.PI*(Radius*Radius)*Height));
    }

}
