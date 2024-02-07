

using Task._3;

while (true) //tipa cvest prota nopurra bo sababi vaqt nrasid
{
    var loc = new Lock();
    loc.Anything = "Home";
    System.Console.WriteLine($"You near home. \n{loc.TurnOff()}\n Your action : <for Open door enter open> ");
    string door = Console.ReadLine();
    door = door.ToLower();
    if (door == "open")
    {
        System.Console.WriteLine($"You near home. \n{loc.TurnOn()} Your action : <for going to home enter go> ");
        string door1 = Console.ReadLine();
        door1 = door1.ToLower();
        if (door1 == "go")
        {
            var home = new Lamp();
            home.Color = "read";
            System.Console.WriteLine(home.TurnOff());
            System.Console.WriteLine("Your action : <for Turn on the light enter on>");
            string lig = Console.ReadLine();
            lig = lig.ToLower();
            if (lig == "on")
            {
                System.Console.WriteLine(home.TurnOn());
            }
        }
    }


}