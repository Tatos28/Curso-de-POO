using Lab4;

public class Ciudadano : Person
{
    public Ciudadano(string name, int health)
        : base(name, health)
    {
    }

    public override int Defend()
    {
        int damage = GetDamage();
        Console.WriteLine($"{name} lucha furiosisimo y realiza {damage} ptos. de daño");
        return damage;
    }

    public override int GetDamage()
    {
        Random rnd = new Random();
        return rnd.Next(7, 20);
    }

    public void Hide()
    {
        Console.WriteLine($"{name} está oculto");
    }
}