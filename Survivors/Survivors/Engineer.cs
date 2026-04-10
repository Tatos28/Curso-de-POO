namespace Survivors;

public class Engineer : Person
{
    private string trapName;

    public Engineer(string name, int health, string trapName)
        : base(name, health)
    {
        this.trapName = trapName;
    }

    public override int Defend()
    {
        int damage = GetDamage();
        Console.WriteLine($"{name} uses {trapName} and deals {damage} damage.");
        return damage;
    }

    public override int GetDamage()
    {
        Random rnd = new Random();
        return rnd.Next(10, 21);
    }

    public void ResetTrap()
    {
        Console.WriteLine($"{name} reset the trap {trapName}");
    }
}