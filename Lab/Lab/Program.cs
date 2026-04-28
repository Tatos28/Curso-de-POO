using Lab;


class Program
{
    static void Main(string[] args)
    {
        
        Band banda = new Band("ThePrice", "Mexico", "Rock", 5);

        Console.WriteLine($"Ey, neccesitamos un escenario {banda.GetStageSize()} para ThePrice!\n");

        banda.Perform();
        Console.WriteLine();
        if (banda.PlayEncore())
        {
            Console.WriteLine("La banda anima al público! \n");
        }
        else
        {
            Console.WriteLine("Terminó muy pronto, que mal\n");
        }
        
        
        DJ dj = new DJ("Santiago Rimbobante", "Guatemala", "Electronic", "FL Studio");

        
        int duration = dj.MixTrack();
        Console.WriteLine($"Santiago el Rimbombante trae un set de {duration} segundos de duración \n");

        int energy = dj.GetEnergyLevel();
        if (energy == 1)
            Console.WriteLine("De chill");
        else if (energy == 2)
            Console.WriteLine("Que loco!");
     
    }
}

