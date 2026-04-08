using Ejercicio;

class Program
{
    static void Main(string[] args)
    {
        Character personaje = new Character("Red");
        Ghost fantasma = new Ghost("Gengar");

        personaje.Introduce();
        fantasma.Introduce();
    }
}