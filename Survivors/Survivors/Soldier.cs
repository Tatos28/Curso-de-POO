namespace Survivors;

public class Soldier : Person
{
    private int ammo;

    public Soldier(string name, int health, int ammo)
        : base(name, health)
    {
        this.ammo = ammo;
    }

    public override int Defend()
    {
        if (ammo > 0)
        {
            ammo--;
            int damage = GetDamage();
            Console.WriteLine($"{name} shoots and deals {damage} damage. Ammo left: {ammo}");
            return damage;
        }
        else
        {
            Console.WriteLine($"{name} has no ammo!");
            return 0;
        }
    }

    public override int GetDamage()
    {
        Random rnd = new Random();
        return rnd.Next(15, 26);
    }

    public void Reload()
    {
        ammo += 5;
        Console.WriteLine($"{name} reloaded. He still has {ammo}");
    }
}