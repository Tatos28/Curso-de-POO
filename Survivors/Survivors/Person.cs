namespace Survivors;

public class Person
{
    protected string name;
    protected int health;

    public Person(string name, int health)
    {
        this.name = name;
        this.health = health;
    }

    public virtual int Defend()
    {
        int damage = GetDamage();
        Console.WriteLine($"{name} defends and deals {damage} damage.");
        return damage;
    }

    public virtual int GetDamage()
    {
        Random rnd = new Random();
        return rnd.Next(1, 5);
    }

    public void GetStatus()
    {
        Console.WriteLine($"{name} has {health} health.");
    }
}