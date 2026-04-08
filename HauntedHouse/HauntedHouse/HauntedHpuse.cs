public class HauntedHouse
{
  
    private string name;
    private string address;
    private int horrorLevel;

    
    public HauntedHouse(string name, string address, int horrorLevel)
    {
        this.name = name;
        this.address = address;
        this.horrorLevel = horrorLevel;
    }

    // Método 1
    public void ShowInfo()
    {
        Console.WriteLine("Nombre de la casa: " + name);
        Console.WriteLine("Dirección: " + address);
        Console.WriteLine("Nivel de terror " + horrorLevel);
    }

    // Método 2
    public void SpookVisitors()
    {
        if (horrorLevel == 1)
        {
            Console.WriteLine("La casa hace ruidos raros... pero no es tan aterradora ");
        }
        else if (horrorLevel == 2)
        {
            Console.WriteLine("Las luces parpadean y se escuchan pasos ");
        }
        else if (horrorLevel == 3)
        {
            Console.WriteLine("Aparecen sombras en las paredes y se oyen gritos en la oscuridad ");
        }
        else if (horrorLevel == 4)
        {
            Console.WriteLine("Se alcanza a ver una figura parada en la casa con su mirada fija en ti ");
        }
        else
        {
            Console.WriteLine("Nivel de terror desconocido ");
        }
    }
}