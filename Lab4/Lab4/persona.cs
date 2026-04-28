using Lab4;

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
        Console.WriteLine($"{name} defiende y hace {damage} ptos. de daño");
        return damage;
    }

    public virtual int GetDamage()
    {
        Random rnd = new Random();
        return rnd.Next(1, 10);
    }

    public void GetStatus()
    {
        Console.WriteLine($"{name} tiene {health} ptos. de salud");
    }
}
