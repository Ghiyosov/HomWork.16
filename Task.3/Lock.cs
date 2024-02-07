namespace Task._3;

public class Lock : IDevice
{
    public string Anything { get; set; } //tilifon khona moshin
    public string TurnOff()
    {
        return $"The {Anything} is blocked";
    }

    public string TurnOn()
    {
        return $"The {Anything} is open";
    }

}
