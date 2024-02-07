using System.Security.Cryptography.X509Certificates;

namespace Task._1;

public class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Year {get; set;}
    public Person(int id, string name, int year)
    {
        Id = id;
        Name = name;
        Year = year;    
    }
    public Person()
    {
        
    }
    public virtual void Great()
    {
        System.Console.WriteLine($"Hello\nmy name is : {Name}");
    }
     public virtual void ShowAge()
    {
        System.Console.WriteLine($"{Year} years old");
    }

}
