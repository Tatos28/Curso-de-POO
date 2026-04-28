using Lab4;

public class Inge : Person
{
    public string trapName;

    public Inge(string name, int health, string trapName)
        : base(name, health)
    {
        this.trapName = trapName;
    }

    public override int Defend()
    {
        int damage = GetDamage();
        Console.WriteLine($"{name} usa {trapName} para hacer {damage} ptos. de daño");
        return damage;
    }

    public override int GetDamage()
    {
        Random rnd = new Random();
        return rnd.Next(17, 29);
    }

    public void ResetTrap()
    {
        Console.WriteLine($"{name} recuperó su trampa: {trapName}");
    }
}