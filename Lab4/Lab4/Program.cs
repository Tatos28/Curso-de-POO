namespace Lab4;
    
using Lab4;

class Program
{
    static void Main(string[] args)
    {
       
        Ciudadano ciudadano1 = new Ciudadano("Ciudadano Marcos", 150);
        Ciudadano ciudadano2 = new Ciudadano("Ciudadano Baltazar", 180);
        Soldado soldado = new Soldado("Soldado Chapa", 200, 6);
        Inge inge = new Inge("Ingeniero Alonso", 100, "Torreta");

        Console.WriteLine("Una horda viene!\n");

        int totalDamage = 0;
        
        
        for (int turn = 1; turn <= 5; turn++)
        {
            Console.WriteLine($" TURNO  {turn} \n");

           
                Console.WriteLine("Marcos se está defendiendo");
            totalDamage += ciudadano1.Defend();
            Console.WriteLine();

         
            Console.WriteLine("Baltazar se está defendiendo");
            totalDamage += ciudadano2.Defend();
            Console.WriteLine();

           
            Console.WriteLine("Chapa está defendiendo");
            totalDamage += soldado.Defend();
            soldado.Reload();
            Console.WriteLine();

            
            Console.WriteLine("El inge Alonso se está defendiendo");
            totalDamage += inge.Defend();
            inge.ResetTrap();
            Console.WriteLine();
        }

        Console.WriteLine($"La horda fue derrotada. El daño total fue de {totalDamage}");
    }
}

