namespace Task._1;

public class Teacher : Person
{
    public string Explane { get; set; }
    public Teacher(int id, string name, int year, string explane) : base(id, name, year)
    {
        Explane = explane;
    }
    public Teacher()
    {
        
    }
    public void Explaine()
    {
        System.Console.WriteLine($"I'm explaining {Explane}");
    }
    
}
