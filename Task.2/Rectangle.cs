using System.Drawing;

namespace Task;

public class Rectangle : Shape
{
    public double S { get; set; }
    public double Width { get; set; }
    public double Length { get; set; }
    public Rectangle(string color, double s, double width, double length):base(color)
    {
        S = s;
        Width =width;
        Length =length;      
    }
    public Rectangle()
    {
        
    }
    
    public override void CalculateArea()
    {
        System.Console.WriteLine(Length*Width);
    }
     public override void CalculateVolume()
    {
        System.Console.WriteLine(S*Length*Width);
    }
}
