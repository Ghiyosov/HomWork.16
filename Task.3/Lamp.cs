namespace Task._3;

public class Lamp : IDevice
{
    public string Color { get; set; }
    public string TurnOff()
    {
        return $"It became dark";
    }

    public string TurnOn()
    {
        return $"There was a {Color} light";
    }

}
