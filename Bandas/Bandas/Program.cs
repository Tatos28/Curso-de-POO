using Bandas;


class Program
{
    static void Main(string[] args)
    {
        
        Band band = new Band("Ilusion", "Mexico", "Rock Alternativo", 5);

        Console.WriteLine($"Hey, we need a {band.GetStageSize()} stage for Ilusión!\n");

        band.Perform();
        Console.WriteLine();

        if (band.PlayEncore())
        {
            Console.WriteLine("The band is playing an encore! \n");
        }
        else
        {
            Console.WriteLine("Oh, it ended too soon.\n");
        }
        
        DJ dj = new DJ("Fred Again", "London", "Electronic", "VirtualDJ");

        int duration = dj.MixTrack();
        Console.WriteLine($"Fred again track is {duration} seconds long\n");

        int energy = dj.GetEnergyLevel();

        if (energy == 1)
            Console.WriteLine("So chill");
        else if (energy == 2)
            Console.WriteLine("This is crazy man!");
     
    }
}