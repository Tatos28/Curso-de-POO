namespace Ejercicio;

public class Ghost : Character
{
    public Ghost(string name) : base(name)
    {
    }

    public override void Introduce()
    {
        Console.WriteLine($"Wazaaaa, yo soy {name}");
        Console.WriteLine("*desaparece lentamente* ");
    }
}