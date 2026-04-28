using Lab4;

public class Soldado : Person
{
    private int ammo;

    public Soldado(string name, int health, int ammo)
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
            Console.WriteLine($"{name} apunta, dispara y hace {damage} ptos. de daño. Munición restante: {ammo}");
            return damage;
        }
        else
        {
            Console.WriteLine($"{name} se quedó sin munición!");
            return 0;
        }
    } public override int GetDamage()
    {
        Random rnd = new Random();
        return rnd.Next(11, 50);
    }

    public void Reload()
    {
        ammo += 5;
        Console.WriteLine($"{name} recargó su arma. Aún le quedan: {ammo} de munición restante");
    }
}