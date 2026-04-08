using System;


namespace NPC
{
    public class Personaje
    {
        private string name;

        public Personaje(string nombre)
        {
            name = nombre;
        }

        public void React(string mensaje)
        {
            Console.WriteLine(name + " reacciona: Hmm... " + mensaje);
        }

        public void React(string mensaje, int nivel)
        {
            if (nivel == 1)
                Console.WriteLine(name + " (tranquilo): " + mensaje);
            else if (nivel == 2)
                Console.WriteLine(name + " (serio): " + mensaje);
            else if (nivel == 3)
                Console.WriteLine(name + " (molesto): " + mensaje);
            else
                Console.WriteLine(name + ": No entiendo cómo reaccionar...");
        }

        public void React(string mensaje, bool esAmigo)
        {
            if (esAmigo)
                Console.WriteLine(name + " (amable): " + mensaje);
            else
                Console.WriteLine(name + " (serio): " + mensaje);
        }
    }
}