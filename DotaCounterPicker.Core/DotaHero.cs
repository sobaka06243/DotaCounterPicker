namespace DotaCounterPicker.Core;

public class DotaHero
{
    public DotaHero(string name, double disadvantage)
    {
        Name = name;
        Disadvantage = disadvantage;
    }

    public string Name { get; }

    public double Disadvantage { get; }
}