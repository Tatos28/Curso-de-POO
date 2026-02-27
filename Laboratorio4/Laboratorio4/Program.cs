public class Character
{
    private string name;
    private int health;
    private int maxHealth;

    public Character(string name, int health)
    {
        this.name = name;
        this.health = health;
        this.maxHealth = health;
    }

    public void ShowStats()
    {
        Console.WriteLine($"Nombre: {name} \nVida: {health}/{maxHealth}");
    }

    public void ReceiveDamage(int damage)
    {
        if (damage <= 0)
        {
            Console.WriteLine("El daño debe ser positivo.");
            return;
        }

        health -= damage;
        Console.WriteLine($"{name} recibió {damage} puntos de daño.");

        if (health <= 0)
        {
            health = 0;
            Lose();
        }
    }

    public void Heal(int amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("La curación debe ser positiva.");
            return;
        }

        health += amount;

        if (health > maxHealth)
            health = maxHealth;

        Console.WriteLine($"{name} se cura {amount} puntos");
    }

    private void Lose()
    {
        Console.WriteLine($"El personaje {name} ha perdido");
    }
}