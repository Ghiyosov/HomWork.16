namespace Task._1;

public class Student : Person
{
    public string Studying { get; set; }
    public Student(int id, string name, int year, string studying) : base(id, name, year)
    {
    
        Studying = studying; 
    
    }
      public virtual void Study()
    {
        System.Console.WriteLine($"I'm studying {Studying}");
    }
    public override void Great()
    {
        System.Console.WriteLine($"Hello\nmy name is : {Name} I'm a student ");
    }
     public override void ShowAge()
    {
        System.Console.WriteLine($"My age is {Year} years old");
    }
}
