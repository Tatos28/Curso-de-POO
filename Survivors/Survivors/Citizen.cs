namespace Survivors;

public class Citizen : Person
{
    public Citizen(string name, int health)
        : base(name, health)
    {
    }

    public override int Defend()
    {
        int damage = GetDamage();
        Console.WriteLine($"{name} fights desperately and deals {damage} damage.");
        return damage;
    }

    public override int GetDamage()
    {
        Random rnd = new Random();
        return rnd.Next(5, 11);
    }

    public void Hide()
    {
        Console.WriteLine($"{name} is hiding.");
    }
}