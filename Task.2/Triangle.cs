namespace Task;

public class Triangle : Shape
{
    public double Base { get; set; }
    public double PerpendicularHeight { get; set; }

    public override void CalculateArea()
    {
        System.Console.WriteLine((1/2)*Base*PerpendicularHeight);
    }
    public override void CalculateVolume()
    {
        System.Console.WriteLine(((Base*Base)*Math.Sqrt(3))/4);
    }


}
