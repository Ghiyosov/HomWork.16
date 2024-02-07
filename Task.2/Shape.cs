namespace Task;

public abstract class Shape
{
    string _color;
    public Shape(string color)
    {
        _color = color;
    }
    public Shape()
    {
        
    }


    public abstract void CalculateArea();
    public abstract void CalculateVolume();
   
}
