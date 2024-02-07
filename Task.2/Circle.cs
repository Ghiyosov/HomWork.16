
namespace Task;

public class Circle : Shape

{
    public double Radius { get; set; }
    public double Height { get; set; }
    public Circle(string color, double radius, double height) : base(color)
    {
        Radius = radius;
        Height = height;
    }
    public Circle()
    {
        
    }

    public override void CalculateArea()
    {
        System.Console.WriteLine(Math.PI*(Radius*Radius));
    }
    public override void CalculateVolume()
    {
        System.Console.WriteLine(Math.PI*(Radius*Radius)*Height);
    }
}
