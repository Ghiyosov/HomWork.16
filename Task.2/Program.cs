
using Task;

while(true)
{
    System.Console.WriteLine("Canculate Area or Volume");
    string canc = Console.ReadLine();
    canc = canc.ToLower();
    if(canc == "area")
    {  //Hmasha dobavit mekardm vakt narasid
        System.Console.WriteLine("What area canculet : circle, rectangle, triangle, cube, culinder");
        string figura = Console.ReadLine();
        figura = figura.ToLower();
        if(figura=="circle")
        {
            var circl = new Circle();
            System.Console.Write("Radius : ");
            double rad = Convert.ToDouble(Console.ReadLine());
            circl.Radius = rad;
            circl.CalculateArea();
        }
        if(figura=="rectangle")
        {
            var circl = new Rectangle();
            System.Console.Write("Width : ");
            double rad = Convert.ToDouble(Console.ReadLine());
            System.Console.Write("Lenght : ");
            double rad1 = Convert.ToDouble(Console.ReadLine());
            circl.Width = rad;
            circl.Length = rad1;
            circl.CalculateArea();
        }
    }
       if(canc == "volume")
    {
        System.Console.WriteLine("What volume canculet : circle, rectangle, triangle, cube, culinder");
        string figura = Console.ReadLine();
        figura = figura.ToLower();
        if(figura=="circle")
        {
            var circl = new Circle();
            System.Console.Write("Radius : ");
            double rad = Convert.ToDouble(Console.ReadLine());
            System.Console.Write("Height : ");
            double rad1 = Convert.ToDouble(Console.ReadLine());
            circl.Radius = rad;
            circl.Height = rad1;
            circl.CalculateVolume();
        }
        if(figura=="rectangle")
        {
            var circl = new Rectangle();
            System.Console.Write("Width : ");
            double rad = Convert.ToDouble(Console.ReadLine());
            System.Console.Write("Lenght : ");
            double rad1 = Convert.ToDouble(Console.ReadLine());
            System.Console.Write("Height : ");
            double rad2 = Convert.ToDouble(Console.ReadLine());
            circl.Width = rad;
            circl.Length = rad1;
            circl.S = rad2;
            circl.CalculateVolume();
        }
    }
}


