namespace Laboratorio4;

class Program
{
    static void Main(string[] args)
    {
        Character character = new Character("Ronin", 2000);

        character.ShowStats();
        character.ReceiveDamage(500);
        character.ShowStats();
        character.Heal(200);
        character.ShowStats();
    }
}