namespace Task;

public class Cube : Shape
{
    public double A { get; set; }
  
    public Cube(string color, double a):base(color)
    {
        A = a;
    }
    public Cube()
    {
        
    }
    public override void CalculateArea()
    {
        System.Console.WriteLine(6*A*A);
    }
     public override void CalculateVolume()
    {
        System.Console.WriteLine(Math.Pow(A,3));
    }
}
