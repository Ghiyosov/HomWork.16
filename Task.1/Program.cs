





using System.Data.Common;
using Task._1;

while (true)
{
    System.Console.WriteLine("***********************************************");
    System.Console.WriteLine("Teacher");
    System.Console.WriteLine("Student");
    System.Console.Write("Who are you: ");
    string person = Console.ReadLine();
    person = person.ToLower();
    if (person == "teacher")
    {
        System.Console.Write("Id :");
        int id = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("Name :");
        string name = Console.ReadLine();
        System.Console.Write("Age :");
        int age = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("Explaine :");
        string exp = Console.ReadLine();
        var teacher = new Teacher(id, name, age, exp);
        System.Console.WriteLine("------for info, enter GetInfo-------");
        string info = Console.ReadLine();
        info = info.ToLower();
        if (info == "getinfo")
        {
            teacher.Great();
            teacher.ShowAge();
            teacher.Explaine();
        }
        System.Console.WriteLine("-----for exit, enter exit--------");
        string ext = Console.ReadLine();
        ext = ext.ToLower();
        if (exp == "exit") break;
    }
    if (person == "student")
    {
        System.Console.Write("Id :");
        int id = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("Name :");
        string name = Console.ReadLine();
        System.Console.Write("Age :");
        int age = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("Studying :");
        string exp = Console.ReadLine();
        var teacher = new Student(id, name, age, exp);
        System.Console.WriteLine("------for info, enter GetInfo-------");
        string info = Console.ReadLine();
        info = info.ToLower();
        if (info == "getinfo")
        {
            teacher.Great();
            teacher.ShowAge();
            teacher.Study();
        }
        System.Console.WriteLine("-----for exit, enter exit--------");
        string ext = Console.ReadLine();
        ext = ext.ToLower();
        if (exp == "exit") break;
    }
    if (person=="stop") return; //baroy sikla mahkam kardan
    else continue;
}